[官方文档](https://docs.unity3d.com/Packages/com.unity.mathematics@1.2/manual/index.html)

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
| asin | 求反余弦值 |
| atan | 求反正切值 |
| atan2 | 求方位角,指坐标原点为起点，指向(x,y)的射线在坐标平面上与x轴正方向之间的角的角度 | 
| cos | 求余弦值 |
| cosh | 求双曲余弦值 |
| sin | 求正弦值 |
| sincos | 分别返回正弦值和余弦值 |
| sinh | 求双曲正弦值 |
| tan | 求正切值 |
| tanh | 求双曲正切值 |

### 掩码

| 方法 | 说明 |
| --- | --- |
| bitmask | 返回按照地位到高位顺序的`bool4`的掩码模式,如(true,true,false,true)，将产生值`(1011)B=(11)D`|
| ~~compress~~ | ~~???打包启用位掩码的参数???~~ |
| countbits | 返回二进制表示中1的个数，也称汉明权重 |
| rol | 向左位移n位 |
| ror | 向右位移n位 |
| lzcnt | 返回二进制表示前导零的数量,`(int)1`前导零数量为31 |
| tzcnt | 返回二进制表示尾随零的数量,`(int)2`尾随零数量为1 |
| reversebits | 反转二进制表示的每一位 |

### 逻辑

| 方法 | 说明 |
| --- | --- |
| all | 所有值为true或非0返回`true`,否则返回`false` |
| any | 其中一个值为true或非0返回`true`,否则返回`false` |
| clamp | 返回限制范围内的值，包含首尾 |
| cmax | 返回最大分量 |
| cmin | 返回最小分量 |
| max | 返回最大值 |
| min | 返回最小值 |
| select | 如果c为真则返回b，否则返回a |
| sign | 如果数值的符号小于0则为-1，等于0为0，大于零为1 |
| step | 当x(第二个参数)>=y(第一个参数)时，结果为1.0f，否则为0.0f |
| faceforward | 如果两个向量i(第二个参数)和ng(第三个参数)指向同一方向(点积大于等于0)，返回-n(第一个参数)，否则返回n |

### 向量 

| 方法 | 说明 |
| --- | --- |
| dot | 返回点积 |
| cross | 返回叉乘 |
| project | 返回x(第一个参数)在y(第二个参数)上的向量投影 |
| projectsafe | `project`的安全版本,会检查结构是否有限 |
| refract | 返回给定入射向量(第一个参数),法向量(第二个参数),折射率(第三个参数)，求法向量 |
| reflect | 返回 r=i-2.0*dot(i,n)*n,意义是求给定入射向量和法向量求反射向量 |

### 矩阵

| 方法 | 说明 |
| --- | --- |
| conjugate | 返回四元数的共轭值 |
| determinant | 返回矩阵的行列式 |
| fastinverse | 刚体变换的快速矩阵求逆 |
| inverse | 求逆矩阵|
| orthonormalize | 正交归一化矩阵 |
| transform | 矩阵转换 |
| transpose | 矩阵转置 |
| mul | 返回矩阵乘法的结果 |

### 浮点数

| 方法 | 说明 |
| --- | --- |
| f16tof32 | 将`uint`低半位转化为浮点 |
| f32tof16 | 将浮点转换，存储在 uint 的低半位。 |
| frac | 返回浮点数小数部分 |
| isfinite | 输入的是有限浮点数则为真 |
| isinf | 输入的是无限浮点数值则为真 |
| isnan | 如果不是数字则返回真 |
| modf | 将数拆分为小数和整数部分 |
| trunc | 转换为整型浮点数 |
| ceil | 返回大于或等于参数的最小整数 |
| ceillog2 | 返回大于或等于参数的最小以2为底的对数 |
| ceilpow2 | 返回大于或等于参数的最小2次幂 |
| floor | 取不大于x的最大整数 |
| floorlog2 | 即取不大于x的最大以2为底的对数 |
| round | 四舍五入为整数值 |

### 运算

| 方法 | 说明 |
| --- | --- |
| csum | 返回向量分量之和 |	
| degrees | 从弧度转换为角度 |	
| radians| 将角度转换为弧度 |
| distance | 返回两值的距离 |
| distancesq | 返回两值距离的平方 |
| fmod | 返回双精度余数 |
| exp | 返回e的n次方 |	
| exp2 | 返回2的n次方 |
| exp10 | 返回10的n次方 |
| pow |	返回x(第一个参数)的y(第二个参数)次方 |
| log | 返回n以e为底的对数 |
| log2 | 返回n以2为底的对数 |
| log10 | 返回n以10为底的对数 |
| length | 返回模长 |
| lengthsq | 返回模长的平方 |
| rcp | 返回倒数 |
| rsqrt | 返回平方根的倒数 |
| sqrt | 返回平方根 |
| mad | 返回融合乘加 (a*b+c)的结果 | 
| unlerp | 返回x(第三个参数)在[a,b]区间的归一化值，等价于`(x-a)/(b-a)` |
| normalize | 返回`x * 1/length(x)`的标准化向量 |
| normalizesafe | `normalize`的安全版本,当结果不是有限的返回默认值(第二个参数) |

### 其它

| 方法 | 说明 |
| --- | --- |
| abs | 取绝对值 |
| ispow2 | 如果是2的幂则为真 |
| hash | 返回哈希值 |
| hashwide | 返回多元素组成的哈希值 |
| lerp | 返回参数s(第三个参数)从x线性插值到y的结果 |	
| nlerp | 返回归一化线性插值的结果 |
| remap | 从范围[a,b] 到[c,d]映射 |
| RigidTransform | 返回`float3x3`表示旋转和`float3`表示平移的`RigidTransform`|
| rotate | 返回四元数旋转的结果 |
| saturate | 返回夹持到[0,1]的结果 |
| shuffle | 返回转化为bool值的结果 |
| slerp | 返回两个四元数球面插值的结果 |
| smoothstep | 当x在[a,b]时从0到1平滑埃尔米特插值 |
| unitexp | 返回四元数的自然指数 |
| unitlog | 返回单位长度四元数的自然对数 |