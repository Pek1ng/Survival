## RPCS
Netcode使用一种有限的RPCs形式来处理事件。发送方的工作可以发出RPC，然后它们在接收方的工作上执行。

### 注册组件

这将自动生成序列化，反序列化并且注册RPC的所有代码。

```c#
public struct OurRpcCommand : IRpcCommand
{
    public int intData;
    public short shortData;
}
```

### 发送或者接收命令

你必须创建一些实体来发送和接收你创建的命令。为了发送命令，你需要创建一个实体，并将该命令和特殊组件`SendRpcCommandRequestComponent`添加到其中。这个组件有一个叫`TargetConnection`的成员，指的是你要发送这个命令的远程连接。

> 如果TargetConnection被设置为Entity.Null，你将广播该消息。在客户端，你不需要设置这个值，因为你只向服务器发送。

```c#
[WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
public class ClientRpcSendSystem : SystemBase
{
    protected override void OnCreate()
    {
        RequireForUpdate<NetworkIdComponent>();
    }

    protected override void OnUpdate()
    {
        if (Input.GetKey("space"))
        {
            EntityManager.CreateEntity(typeof(OurRpcCommand), typeof(SendRpcCommandRequestComponent));
        }
    }
}
```
```c#
[WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
public class ServerRpcReceiveSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((Entity entity, ref OurRpcCommand cmd, ref ReceiveRpcCommandRequestComponent req) =>
        {
            PostUpdateCommands.DestroyEntity(entity);
            Debug.Log("We received a command!");
        }).Run();
    }
}
```

`RpcSystem`会自动找到所有的请求，将它们发送出去，然后删除发送请求。在远程端，它们显示为具有相同的`IRpcCommand`和一`ReceiveRpcCommandRequestComponent`的实体，你可以用它来识别请求是从哪个连接中接收的。

