## 致命

<details>
<summary>✔访问无效地址</summary>

#### 解决方案
* 经排查System运行在组件添加之前,System添加RequireForUpdate

</details>

<details>
<summary>✔ArgumentException: Cannot find TypeIndex for type hash 7881543491081840453</summary>  

#### 解决思路
1. 很显然，该错误在编辑器模式下正常运行，而IL2CPP构建后出现，大概是代码剥离导致
2. 查询项目目录`Logs\Exported.log` ，该hash对应类型为`Unity.Rendering.PerInstanceCullingTag`

#### 解决方案
任意位置添加`link.xml`文件
```XML
<linker>
<!--Preserve entire assembly-->
<assembly fullname="Unity.Entities.Graphics" preserve="all"/>
</linker>
```

</details>  

## 严重

- [ ] 联机 预估是同步不一致([相同问题](https://forum.unity.com/search/20460489/?q=Large+serverTick&o=date&c[node]=823+147+641+422+425+840))

## 一般

