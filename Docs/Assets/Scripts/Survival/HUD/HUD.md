# UI系统

UGUI基于GameObject,和ECS交互是十分繁琐的，但是又难以把所有流程都放在UI Toolkit

## 设计思路

### 方案一

将UI作为数据（通过`EntityManager.AddComponentObject`），并通过SystemBase对其进行查询管理

这样做基本上是单向的 `ECS -> MonoBehavior`

#### 优点
+ 所需的数据可以直接从System中的实体查询/修改。
+ 只有在相应Component存在时才更新UI（authored）。
+ 如果在OnCreate/OnDestroy（cleanup）中订阅，可以做响应。
(比如，Enabled可以用来切换逻辑)

#### 缺点
- 很明显，被托管，但是，MonoBehaviour本身就是这样，所以也没什么。

### 方案二

我们经常需要知道一些用户界面是否可见，或者它是否显示或隐藏，是否在BurstCompatible代码中。所以要做做一个ECS层来了解/控制ui，称之为ViewSystem。

每个ui元素都有一个实体和一些状态组件。例如，用于显示标题的ui叫做SubtitleView，它有一个这样的实体组成。
```
View
ViewObject
Canvas
CanvasGroup
...
SubtitleView
FixedString64 TextId
SubtitleViewObject
TMProUGUI Text
ViewIsHidden
```
有 "Object "后缀的是一个object component，其他都是IComponentData。通过System可以:  
在SubtitleView上SetComponent来改变文本
在视图实体上添加组件ViewShow来触发视图的显示。  

这样一来，结构就非常清晰，在某个地方把新的文字改到TextMeshPro Component，把新的Alpha值应用到Canvas Group上，这样其他系统通过查询SubtitleView和ViewIsShown标签，知道当前是否显示，最重要的是这些代码都会被Burst编译。