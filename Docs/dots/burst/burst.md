## 在什么时候，什么地方使用 `[BurstCompile]`

[查看原文](https://forum.unity.com/threads/when-where-and-why-to-put-burstcompile-with-mild-under-the-hood-explanation.1344539/)

首先要知道的两件事：

1. **Burst只能编译静态方法**。对于这种情况，只需在静态方法及其声明类型上加上`[BurstCompile]`的Attribute，当你调用这个方法时，如果Burst编译没有失败，它会自动调用Burst编译的版本。
2. 除非你想尽办法避免，否则所有Burst编译的代码调用的c#代码都是Burst编译过的。

如果上面的第一种情况是真的，你会问，每个job(如IJobEntity)的Execute方法（不是静态的），以及ISystem的OnUpdate 等（也不是静态的）是怎么回事？答案是：做了特别的处理。

举个例子，你可以看这里 https://github.com/Unity-Technologies/UnityCsReference/blob/2022.2/Runtime/Jobs/Managed/IJob.cs#L36 

在`IJob interface`上有这样的特性
```C#
[JobProducerType(typeof(IJobExtensions.JobStruct<>))]
public interface IJob
{
    void Execute();
}
```

如果你把 `[BurstCompile]`放在一个实现了此接口的类型上，Burst 知道要在接口上寻找这个特性，去找那个类型（在这个例子中是`IJobExtensions.JobStruct`，确保它是通用的。并用你的的Job结构体来泛型专门化它（使它成为 `IJobExtensions.JobStruct<你自定义的Job>）`，然后在其他类型上编译静态 Execute 方法。其他类型的静态Execute方法将在一些参数和上下文中调用你的Execute，你的Execute将作这个的静态函数的一部分被Burst编译（结论的第2点）。

有[BurstCompile]的job结构的非 Execute 方法在没有被Burst编译的代码中调用时不会被Burst编译（除非它们是静态的，并且你把[BurstCompile]放在它们以及job结构上）。但是，如前所述，所有从Bursted代码调用的都是Bursted的。

之所以需要你把`[BurstCompile]`放在声明类型以及静态方法上，是为了减少扫描什么方法需要Burst的时间。如果我们不在类型上要求它，它就必须到每个类型的每个方法中去检查属性，而这种方式只需检查类型本身，如果该类型没有属性，就可以继续前进。这也适用于ISystem的。

如果你曾经担心某些特定的代码是被编译还是未编译的，你可以使用以下方法。

```C#
[BurstDiscard]
void SetFalseIfUnBursted(ref bool val)
{
     val = false;
}
 
bool IsBursted()
{
    bool ret = true;
    SetFalseIfUnBursted(ref ret);
    return ret;
}
```

根据这个函数的值来改变行为也许显然是不可取的，因为那样的话，当你关闭Burst的时候，行为就会改变。