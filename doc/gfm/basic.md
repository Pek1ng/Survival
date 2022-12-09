<details><summary>标题</summary>
<p>

```
# The largest heading
## The second largest heading
###### The smallest heading
```

# The largest heading
## The second largest heading
###### The smallest heading

</p>
</details>


<details><summary>文本样式</summary>
<p>

| 样式 | 语法 | 示例 | 效果 |
| --- | --- | --- | --- |
| Bold | `** **`或者`__ __` | `**Bold**` | **Bold** |
| Italic | `* *` 或者 `_ _` | `*Italic*` | *Italic* |
| Strikethrough | `~~ ~~` | `~~This was mistaken text~~` | ~~This was mistaken text~~ |
| Bold and nested italic | `** **` 和 `_ _` | `**This text is _extremely_ important**` | **This text is _extremely_ important** |
| All bold and italic | `*** ***` | `***All this text is important***` | ***All this text is important*** |
| Subscript | `<sub> </sub>` | `<sub>This is a subscript text</sub>` | <sub>This is a subscript text</sub> |
| Superscript | `<sup> </sup>` | `<sup>This is a superscript text</sup>` | <sup>This is a superscript text</sup> |
```

```

</p>
</details>

<details><summary>段落</summary>
<p>

```
`> 这是一个引用`
```

> 这是一个引用

</p>
</details>

<details><summary>代码片段</summary>
<p>

````
```C#
using System;
using Unity.Entities;

namespace Survival.Items
{
    [Serializable]
    public struct ItemData : IComponentData
    {
        public int MaxStacks;
    }
}
```
````

```C#
using System;
using Unity.Entities;

namespace Survival.Items
{
    [Serializable]
    public struct ItemData : IComponentData
    {
        public int MaxStacks;
    }
}
```

> 这是一个引用

</p>
</details>

<details><summary>颜色</summary>
<p>

| 颜色 | 语法 | 效果 |
| --- | --- | --- |
| HEX | `#RRGGBB` | #RRGGBB |
| RGB | `rgb(9, 105, 218)` | rgb(9, 105, 218) |
| HSL | `hsl(H,S,L)` | hsl(H,S,L) |

</p>
</details>

<details><summary>链接</summary>
<p>

```
更多文档 [GitHub Docs](https://docs.github.com/cn/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
```

更多文档 [GitHub Docs](https://docs.github.com/cn/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).

您可以直接链接到渲染文件中的某个部分，方法是将鼠标悬停在该部分标题上以显示链接

</p>
</details>

<details><summary>图像</summary>
<p>

```
![This is an image](https://myoctocat.com/assets/images/base-octocat.svg)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>
```

![This is an image](https://myoctocat.com/assets/images/base-octocat.svg)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

</p>
</details>

<details><summary>引用路径</summary>
<p>

| 内容 | 链接 |
| --- | --- |
| 同分支 | `/assets/images/electrocat.png` |
| 不同分支 | `/../main/assets/images/electrocat.png` |
| 在Issues,Pull requests和comments | `../blob/main/assets/images/electrocat.png?raw=true` |
| 在其他仓库 | `/../../../../github/docs/blob/main/assets/images/electrocat.png` |
| 在其他仓库Issues,Pull requests和comments | ../../../github/docs/blob/main/assets/images/electrocat.png?raw=true |

</p>
</details>

<details><summary>列表</summary>
<p>

```
- George Washington
* John Adams
+ Thomas Jefferson

1. James Madison
2. First list item
   - First nested list item
     - Second nested list item

- [x] #739
- [ ] Add delight to the experience when all tasks are complete :tada:
```

- George Washington
* John Adams
+ Thomas Jefferson

1. James Madison
2. First list item
   - First nested list item
     - Second nested list item

- [x] #739
- [ ] Add delight to the experience when all tasks are complete :tada:

</p>
</details>