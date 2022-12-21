
## 方法

### 方向

| 方法 | 说明 |
| --- | --- |
| back | (0,0,-1) |
| down | (0,-1,0) |
| forward | (0,0,1) |
| left | (-1,0,0) |
| right | (1,0,0) |
| up |(0,1,0) |

### 三角函数

| 方法 | 说明 |
| --- | --- |
| acos | 求反余弦值 |
| atan | 反正切值 |
| atan2 | 双精度反正切值 | 
| asin | 求反余弦值 |
| cos | 求余弦值 |
| cosh | 双曲余弦 |
| tan | 返回正切值 |
| tanh | 返回双曲正切值 |
| sin | 返回正弦值的结果 |
| sincos | 分别返回正弦值和余弦值 |
| sinh | 返回双曲正弦值 |

### 位操作

| 方法 | 说明 |
| --- | --- |
| bitmask | 返回`bool4`位掩码模式,如(true,true,false,true)，将产生值`1101`|
| countbits | 返回二进制中1的个数，也称汉明权重 |
| compress | 将启用位掩码打包到左侧 |
| rol | 向左位移n位 |
| ror | 向右位移n位 |
| lzcnt | 返回二进制前导0的数量 |
| tzcnt | 返回二进制表示的尾随零计数 |
| reversebits | 返回反转int值的位模式结果 |

### 逻辑

| 方法 | 说明 |
| --- | --- |
| all | 所有值为true或非0返回`true`,否则返回`false` |
| any | 其中一个值为true或非0返回`true`,否则返回`false` |
| cmax | 返回最大分量 |
| cmin | 返回最小分量 |
| max | 返回最大值 |
| min | 返回最小值 |
| select | 如果c为真则返回b，否则返回a |
| ceil | 返回大于或等于参数的整数结果 |
| clamp | 返回限制范围内的值，包含首尾 |
| ceillog2 | 返回以2为底对数的值的ceil |
| ceilpow2 | 返回大于或等于输入的最小2次幂 |
| floor | 返回四舍五入的结果 |
| floorlog2 | 计算X以2为底对数四舍五入的结构 |
| sign | 返回双精度的符号小于0则为-1，等于0为0，大于零为1 |
| step | 返回一个阶梯函数的结果，当x>=y时，结果为1.0f，否则为0.0f |
| faceforward | 如果两个向量i和ng指向同一方向，有条件地翻转一个向量n。如果dot(i, ng)< 0，返回n，否则返回-n |

### 向量 

| 方法 | 说明 |
| --- | --- |
| dot | 返回点积 |
| cross | 返回叉乘 |
| project | 返回x在y上的向量投影 |
| projectsafe | 返回x在y上的向量投影安全版本 |
| refract | 返回折射向量 |
| reflect | 返回 r=i-2.0*dot(i,n)*n,意义是求给定入射向量和法向量求反射向量 |

### 矩阵

| 方法 | 说明 |
| --- | --- |
| conjugate | 返回共轭值 |
| determinant | 返回矩阵的行列式 |
| fastinverse | 刚性变换的快速矩阵求逆 |
| inverse | 求矩阵的全逆 |
| transform | 返回矩阵转换的结果 |
| transpose | 返回矩阵转置的结果 |
| mul | 返回矩阵乘法的结果 |

### 类型
| 方法 | 说明 |
| --- | --- |
| asdouble | 将值转为`double`类型 |
| asfloat | 将值转为`float`类型 |
| asint | 转为`int`类型 |
| aslong | 转为`long`类型 |
| asuint | 转为`uint`类型 |
| asulong | 转为`ulong`类型 |


### 浮点数

| 方法 | 说明 |
| --- | --- |
| f16tof32 | 返回最接近的半精度浮点 |
| f32tof16 | 返回最接近的半精度浮点 |
| frac | 返回小数部分 |
| isfinite | 输入的是有限浮点值则为真 |
| isinf | 输入的是无限浮点值则为真 |
| isnan | 如果不是数字则返回真 |
| modf | 将数拆分为小数和整数部分 |
| half | 返回由双精度构造的半精度值 |
| trunc | 转换为整型双精度 |

### 其它

| 方法 | 说明 |
| --- | --- |
| abs | 取绝对值 |
| csum | 返回向量分量之和 |	
| degrees | 从弧度转换为角度 |	
| distance | 返回两值的距离 |
| distancesq | 返回两值距离的平方 |
| exp | 返回X以e为底的指数 |	
| exp10 | 返回X以10为底的是指数 |
| exp2 | 返回X以10为底的是指数 |
| fmod | 返回双进度余数 |
| hash | 返回哈希值 |
| hashwide | 返回多元素哈希值 |
| ispow2 | 如果是2的幂则为真 |
| length | 返回长度 |
| lengthsq | 返回长度的平方 |
| lerp | 返回线性插值的结构 |	
| log | 返回以e为底的对数 |
| log10 | 返回以10为底的对数 |
| log2 | 返回以2为底的对数 |
| mad | 返回 (a*b+c)的结果 | 
| nlerp | 返回归一化线性插值的结果 |
| normalize | 返回1/length(x)缩放规范化值 |
| normalizesafe | 返回1/length(x)缩放规范化值的安全版本 |
| orthonormalize | 归一化的矩阵正交 |
| pow |	返回x的y次方 |
| radians| 将角度转换为弧度 |
| rcp | 返回倒数 |
| remap | 从范围[a,b] 到[c,d]映射 |
| RigidTransform | 返回`float3x3`表示旋转和`float3`表示平移的`RigidTransform`|
| rotate | 返回四元数旋转的结果 |
| round | 将每个分量四舍五入最近整数值 |
| rsqrt | 返回平方根倒数 |
| saturate | 返回夹持到[0,1]的结果 |
| shuffle | 返回转化为bool值的结果 |
| slerp | 返回两个四元数球面插值的结果 |
| smoothstep | 当x在[a,b]时从0到1平滑埃尔米特插值 |
| sqrt | 返回平方根 |
| unitexp | 返回四元数的自然指数 |
| unitlog | 返回单位长度四元数的自然对数 |
| unlerp | 求(x-a)/(b-a) |