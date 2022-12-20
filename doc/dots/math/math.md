
## 方法

| 方法 | 说明 |
| --- | --- |
| abs | 取绝对值 |
| acos | 求反余弦值 |
| all | 所有值为true或非0返回`true`,否则返回`false` |
| any | 其中一个值为true或非0返回`true`,否则返回`false` |
| asdouble | 将值转为`double`类型 |
| asfloat | 将值转为`float`类型 |
| asin | 求反余弦值 |
| asint | 转为`int`类型 |
| aslong | 转为`long`类型 |
| asuint | 转为`uint`类型 |
| asulong | 转为`ulong`类型 |
| atan | 反正切值 |
| atan2 | 双精度反正切值 | 
| back | (0,0,-1) |
| bitmask | 返回`bool4`位掩码模式,如(true,true,false,true)，将产生值`1101`|
| bool2<br>bool2x2 | 构造相应结构 |
| ceil | 返回大于或等于参数的整数结果 |
| ceillog2 | 返回以2为底对数的值的ceil |
| ceilpow2 | 返回大于或等于输入的最小2次幂 |
| clamp | 返回限制范围内的值，包含首尾 |
| cmax | 返回最大分量 |
| cmin | 返回最小分量 |

compress(Int32*, Int32, int4, bool4)	
Packs components with an enabled mask to the left.

conjugate(quaternion)	
Returns the conjugate of a quaternion value.

cos(float3)	
Returns the componentwise cosine of a float3 vector.

cosh(float4)	
Returns the componentwise hyperbolic cosine of a float4 vector.

countbits(Int32)	
Returns number of 1-bits in the binary representation of an int value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.

cross(double3, double3)	
Returns the cross product of two double3 vectors.

csum(int4)	
Returns the horizontal sum of components of an int4 vector.

degrees(Double)	
Returns the result of converting a double value from radians to degrees.

degrees(double4)	
Returns the result of a componentwise conversion of a double4 vector from radians to degrees.

degrees(float2)	
Returns the result of a componentwise conversion of a double2 vector from radians to degrees.

degrees(float3)	
Returns the result of a componentwise conversion of a double3 vector from radians to degrees.

degrees(float4)	
Returns the result of a componentwise conversion of a double4 vector from radians to degrees.

determinant(double2x2)	
Returns the determinant of a double2x2 matrix.

determinant(double3x3)	
Returns the determinant of a double3x3 matrix.

determinant(double4x4)	
Returns the determinant of a double4x4 matrix.

determinant(float2x2)	
Returns the determinant of a float2x2 matrix.

determinant(float3x3)	
Returns the determinant of a float3x3 matrix.

determinant(float4x4)	
Returns the determinant of a float4x4 matrix.

determinant(int2x2)	
Returns the determinant of a int2x2 matrix.

determinant(int3x3)	
Returns the determinant of a int3x3 matrix.

determinant(int4x4)	
Returns the determinant of a int4x4 matrix.

distance(Double, Double)	
Returns the distance between two double values.

distance(Single, Single)	
Returns the distance between two float values.

distance(double2, double2)	
Returns the distance between two double2 vectors.

distance(double3, double3)	
Returns the distance between two double3 vectors.

distance(double4, double4)	
Returns the distance between two double4 vectors.

distance(float2, float2)	
Returns the distance between two float2 vectors.

distance(float3, float3)	
Returns the distance between two float3 vectors.

distance(float4, float4)	
Returns the distance between two float4 vectors.

distancesq(Double, Double)	
Returns the squared distance between two double values.

distancesq(Single, Single)	
Returns the squared distance between two float values.

distancesq(double2, double2)	
Returns the squared distance between two double2 vectors.

distancesq(double3, double3)	
Returns the squared distance between two double3 vectors.

distancesq(double4, double4)	
Returns the squared distance between two double4 vectors.

distancesq(float2, float2)	
Returns the squared distance between two float2 vectors.

distancesq(float3, float3)	
Returns the squared distance between two float3 vectors.

distancesq(float4, float4)	
Returns the squared distance between two float4 vectors.

dot(Double, Double)	
Returns the dot product of two double values. Equivalent to multiplication.

dot(Int32, Int32)	
Returns the dot product of two int values. Equivalent to multiplication.

dot(Single, Single)	
Returns the dot product of two float values. Equivalent to multiplication.

dot(UInt32, UInt32)	
Returns the dot product of two uint values. Equivalent to multiplication.

dot(double2, double2)	
Returns the dot product of two double2 vectors.

dot(double3, double3)	
Returns the dot product of two double3 vectors.

dot(double4, double4)	
Returns the dot product of two double4 vectors.

dot(float2, float2)	
Returns the dot product of two float2 vectors.

dot(float3, float3)	
Returns the dot product of two float3 vectors.

dot(float4, float4)	
Returns the dot product of two float4 vectors.

dot(int2, int2)	
Returns the dot product of two int2 vectors.

dot(int3, int3)	
Returns the dot product of two int3 vectors.

dot(int4, int4)	
Returns the dot product of two int4 vectors.

dot(quaternion, quaternion)	
Returns the dot product of two quaternions.

dot(uint2, uint2)	
Returns the dot product of two uint2 vectors.

dot(uint3, uint3)	
Returns the dot product of two uint3 vectors.

dot(uint4, uint4)	
Returns the dot product of two uint4 vectors.

double2(Boolean)	
Returns a double2 vector constructed from a single bool value by converting it to double and assigning it to every component.

double2(Double)	
Returns a double2 vector constructed from a single double value by assigning it to every component.

double2(Double, Double)	
Returns a double2 vector constructed from two double values.

double2(Int32)	
Returns a double2 vector constructed from a single int value by converting it to double and assigning it to every component.

double2(Single)	
Returns a double2 vector constructed from a single float value by converting it to double and assigning it to every component.

double2(UInt32)	
Returns a double2 vector constructed from a single uint value by converting it to double and assigning it to every component.

double2(bool2)	
Return a double2 vector constructed from a bool2 vector by componentwise conversion.

double2(double2)	
Returns a double2 vector constructed from a double2 vector.

double2(float2)	
Return a double2 vector constructed from a float2 vector by componentwise conversion.

double2(half)	
Returns a double2 vector constructed from a single half value by converting it to double and assigning it to every component.

double2(half2)	
Return a double2 vector constructed from a half2 vector by componentwise conversion.

double2(int2)	
Return a double2 vector constructed from a int2 vector by componentwise conversion.

double2(uint2)	
Return a double2 vector constructed from a uint2 vector by componentwise conversion.

double2x2(Boolean)	
Returns a double2x2 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double2x2(Double)	
Returns a double2x2 matrix constructed from a single double value by assigning it to every component.

double2x2(Double, Double, Double, Double)	
Returns a double2x2 matrix constructed from from 4 double values given in row-major order.

double2x2(Int32)	
Returns a double2x2 matrix constructed from a single int value by converting it to double and assigning it to every component.

double2x2(Single)	
Returns a double2x2 matrix constructed from a single float value by converting it to double and assigning it to every component.

double2x2(UInt32)	
Returns a double2x2 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double2x2(bool2x2)	
Return a double2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.

double2x2(double2, double2)	
Returns a double2x2 matrix constructed from two double2 vectors.

double2x2(float2x2)	
Return a double2x2 matrix constructed from a float2x2 matrix by componentwise conversion.

double2x2(int2x2)	
Return a double2x2 matrix constructed from a int2x2 matrix by componentwise conversion.

double2x2(uint2x2)	
Return a double2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.

double2x3(Boolean)	
Returns a double2x3 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double2x3(Double)	
Returns a double2x3 matrix constructed from a single double value by assigning it to every component.

double2x3(Double, Double, Double, Double, Double, Double)	
Returns a double2x3 matrix constructed from from 6 double values given in row-major order.

double2x3(Int32)	
Returns a double2x3 matrix constructed from a single int value by converting it to double and assigning it to every component.

double2x3(Single)	
Returns a double2x3 matrix constructed from a single float value by converting it to double and assigning it to every component.

double2x3(UInt32)	
Returns a double2x3 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double2x3(bool2x3)	
Return a double2x3 matrix constructed from a bool2x3 matrix by componentwise conversion.

double2x3(double2, double2, double2)	
Returns a double2x3 matrix constructed from three double2 vectors.

double2x3(float2x3)	
Return a double2x3 matrix constructed from a float2x3 matrix by componentwise conversion.

double2x3(int2x3)	
Return a double2x3 matrix constructed from a int2x3 matrix by componentwise conversion.

double2x3(uint2x3)	
Return a double2x3 matrix constructed from a uint2x3 matrix by componentwise conversion.

double2x4(Boolean)	
Returns a double2x4 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double2x4(Double)	
Returns a double2x4 matrix constructed from a single double value by assigning it to every component.

double2x4(Double, Double, Double, Double, Double, Double, Double, Double)	
Returns a double2x4 matrix constructed from from 8 double values given in row-major order.

double2x4(Int32)	
Returns a double2x4 matrix constructed from a single int value by converting it to double and assigning it to every component.

double2x4(Single)	
Returns a double2x4 matrix constructed from a single float value by converting it to double and assigning it to every component.

double2x4(UInt32)	
Returns a double2x4 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double2x4(bool2x4)	
Return a double2x4 matrix constructed from a bool2x4 matrix by componentwise conversion.

double2x4(double2, double2, double2, double2)	
Returns a double2x4 matrix constructed from four double2 vectors.

double2x4(float2x4)	
Return a double2x4 matrix constructed from a float2x4 matrix by componentwise conversion.

double2x4(int2x4)	
Return a double2x4 matrix constructed from a int2x4 matrix by componentwise conversion.

double2x4(uint2x4)	
Return a double2x4 matrix constructed from a uint2x4 matrix by componentwise conversion.

double3(Boolean)	
Returns a double3 vector constructed from a single bool value by converting it to double and assigning it to every component.

double3(Double)	
Returns a double3 vector constructed from a single double value by assigning it to every component.

double3(Double, Double, Double)	
Returns a double3 vector constructed from three double values.

double3(Double, double2)	
Returns a double3 vector constructed from a double value and a double2 vector.

double3(Int32)	
Returns a double3 vector constructed from a single int value by converting it to double and assigning it to every component.

double3(Single)	
Returns a double3 vector constructed from a single float value by converting it to double and assigning it to every component.

double3(UInt32)	
Returns a double3 vector constructed from a single uint value by converting it to double and assigning it to every component.

double3(bool3)	
Return a double3 vector constructed from a bool3 vector by componentwise conversion.

double3(double2, Double)	
Returns a double3 vector constructed from a double2 vector and a double value.

double3(double3)	
Returns a double3 vector constructed from a double3 vector.

double3(float3)	
Return a double3 vector constructed from a float3 vector by componentwise conversion.

double3(half)	
Returns a double3 vector constructed from a single half value by converting it to double and assigning it to every component.

double3(half3)	
Return a double3 vector constructed from a half3 vector by componentwise conversion.

double3(int3)	
Return a double3 vector constructed from a int3 vector by componentwise conversion.

double3(uint3)	
Return a double3 vector constructed from a uint3 vector by componentwise conversion.

double3x2(Boolean)	
Returns a double3x2 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double3x2(Double)	
Returns a double3x2 matrix constructed from a single double value by assigning it to every component.

double3x2(Double, Double, Double, Double, Double, Double)	
Returns a double3x2 matrix constructed from from 6 double values given in row-major order.

double3x2(Int32)	
Returns a double3x2 matrix constructed from a single int value by converting it to double and assigning it to every component.

double3x2(Single)	
Returns a double3x2 matrix constructed from a single float value by converting it to double and assigning it to every component.

double3x2(UInt32)	
Returns a double3x2 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double3x2(bool3x2)	
Return a double3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.

double3x2(double3, double3)	
Returns a double3x2 matrix constructed from two double3 vectors.

double3x2(float3x2)	
Return a double3x2 matrix constructed from a float3x2 matrix by componentwise conversion.

double3x2(int3x2)	
Return a double3x2 matrix constructed from a int3x2 matrix by componentwise conversion.

double3x2(uint3x2)	
Return a double3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.

double3x3(Boolean)	
Returns a double3x3 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double3x3(Double)	
Returns a double3x3 matrix constructed from a single double value by assigning it to every component.

double3x3(Double, Double, Double, Double, Double, Double, Double, Double, Double)	
Returns a double3x3 matrix constructed from from 9 double values given in row-major order.

double3x3(Int32)	
Returns a double3x3 matrix constructed from a single int value by converting it to double and assigning it to every component.

double3x3(Single)	
Returns a double3x3 matrix constructed from a single float value by converting it to double and assigning it to every component.

double3x3(UInt32)	
Returns a double3x3 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double3x3(bool3x3)	
Return a double3x3 matrix constructed from a bool3x3 matrix by componentwise conversion.

double3x3(double3, double3, double3)	
Returns a double3x3 matrix constructed from three double3 vectors.

double3x3(float3x3)	
Return a double3x3 matrix constructed from a float3x3 matrix by componentwise conversion.

double3x3(int3x3)	
Return a double3x3 matrix constructed from a int3x3 matrix by componentwise conversion.

double3x3(uint3x3)	
Return a double3x3 matrix constructed from a uint3x3 matrix by componentwise conversion.

double3x4(Boolean)	
Returns a double3x4 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double3x4(Double)	
Returns a double3x4 matrix constructed from a single double value by assigning it to every component.

double3x4(Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double)	
Returns a double3x4 matrix constructed from from 12 double values given in row-major order.

double3x4(Int32)	
Returns a double3x4 matrix constructed from a single int value by converting it to double and assigning it to every component.

double3x4(Single)	
Returns a double3x4 matrix constructed from a single float value by converting it to double and assigning it to every component.

double3x4(UInt32)	
Returns a double3x4 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double3x4(bool3x4)	
Return a double3x4 matrix constructed from a bool3x4 matrix by componentwise conversion.

double3x4(double3, double3, double3, double3)	
Returns a double3x4 matrix constructed from four double3 vectors.

double3x4(float3x4)	
Return a double3x4 matrix constructed from a float3x4 matrix by componentwise conversion.

double3x4(int3x4)	
Return a double3x4 matrix constructed from a int3x4 matrix by componentwise conversion.

double3x4(uint3x4)	
Return a double3x4 matrix constructed from a uint3x4 matrix by componentwise conversion.

double4(Boolean)	
Returns a double4 vector constructed from a single bool value by converting it to double and assigning it to every component.

double4(Double)	
Returns a double4 vector constructed from a single double value by assigning it to every component.

double4(Double, Double, Double, Double)	
Returns a double4 vector constructed from four double values.

double4(Double, Double, double2)	
Returns a double4 vector constructed from two double values and a double2 vector.

double4(Double, double2, Double)	
Returns a double4 vector constructed from a double value, a double2 vector and a double value.

double4(Double, double3)	
Returns a double4 vector constructed from a double value and a double3 vector.

double4(Int32)	
Returns a double4 vector constructed from a single int value by converting it to double and assigning it to every component.

double4(Single)	
Returns a double4 vector constructed from a single float value by converting it to double and assigning it to every component.

double4(UInt32)	
Returns a double4 vector constructed from a single uint value by converting it to double and assigning it to every component.

double4(bool4)	
Return a double4 vector constructed from a bool4 vector by componentwise conversion.

double4(double2, Double, Double)	
Returns a double4 vector constructed from a double2 vector and two double values.

double4(double2, double2)	
Returns a double4 vector constructed from two double2 vectors.

double4(double3, Double)	
Returns a double4 vector constructed from a double3 vector and a double value.

double4(double4)	
Returns a double4 vector constructed from a double4 vector.

double4(float4)	
Return a double4 vector constructed from a float4 vector by componentwise conversion.

double4(half)	
Returns a double4 vector constructed from a single half value by converting it to double and assigning it to every component.

double4(half4)	
Return a double4 vector constructed from a half4 vector by componentwise conversion.

double4(int4)	
Return a double4 vector constructed from a int4 vector by componentwise conversion.

double4(uint4)	
Return a double4 vector constructed from a uint4 vector by componentwise conversion.

double4x2(Boolean)	
Returns a double4x2 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double4x2(Double)	
Returns a double4x2 matrix constructed from a single double value by assigning it to every component.

double4x2(Double, Double, Double, Double, Double, Double, Double, Double)	
Returns a double4x2 matrix constructed from from 8 double values given in row-major order.

double4x2(Int32)	
Returns a double4x2 matrix constructed from a single int value by converting it to double and assigning it to every component.

double4x2(Single)	
Returns a double4x2 matrix constructed from a single float value by converting it to double and assigning it to every component.

double4x2(UInt32)	
Returns a double4x2 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double4x2(bool4x2)	
Return a double4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.

double4x2(double4, double4)	
Returns a double4x2 matrix constructed from two double4 vectors.

double4x2(float4x2)	
Return a double4x2 matrix constructed from a float4x2 matrix by componentwise conversion.

double4x2(int4x2)	
Return a double4x2 matrix constructed from a int4x2 matrix by componentwise conversion.

double4x2(uint4x2)	
Return a double4x2 matrix constructed from a uint4x2 matrix by componentwise conversion.

double4x3(Boolean)	
Returns a double4x3 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double4x3(Double)	
Returns a double4x3 matrix constructed from a single double value by assigning it to every component.

double4x3(Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double)	
Returns a double4x3 matrix constructed from from 12 double values given in row-major order.

double4x3(Int32)	
Returns a double4x3 matrix constructed from a single int value by converting it to double and assigning it to every component.

double4x3(Single)	
Returns a double4x3 matrix constructed from a single float value by converting it to double and assigning it to every component.

double4x3(UInt32)	
Returns a double4x3 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double4x3(bool4x3)	
Return a double4x3 matrix constructed from a bool4x3 matrix by componentwise conversion.

double4x3(double4, double4, double4)	
Returns a double4x3 matrix constructed from three double4 vectors.

double4x3(float4x3)	
Return a double4x3 matrix constructed from a float4x3 matrix by componentwise conversion.

double4x3(int4x3)	
Return a double4x3 matrix constructed from a int4x3 matrix by componentwise conversion.

double4x3(uint4x3)	
Return a double4x3 matrix constructed from a uint4x3 matrix by componentwise conversion.

double4x4(Boolean)	
Returns a double4x4 matrix constructed from a single bool value by converting it to double and assigning it to every component.

double4x4(Double)	
Returns a double4x4 matrix constructed from a single double value by assigning it to every component.

double4x4(Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double, Double)	
Returns a double4x4 matrix constructed from from 16 double values given in row-major order.

double4x4(Int32)	
Returns a double4x4 matrix constructed from a single int value by converting it to double and assigning it to every component.

double4x4(Single)	
Returns a double4x4 matrix constructed from a single float value by converting it to double and assigning it to every component.

double4x4(UInt32)	
Returns a double4x4 matrix constructed from a single uint value by converting it to double and assigning it to every component.

double4x4(bool4x4)	
Return a double4x4 matrix constructed from a bool4x4 matrix by componentwise conversion.

double4x4(double4, double4, double4, double4)	
Returns a double4x4 matrix constructed from four double4 vectors.

double4x4(float4x4)	
Return a double4x4 matrix constructed from a float4x4 matrix by componentwise conversion.

double4x4(int4x4)	
Return a double4x4 matrix constructed from a int4x4 matrix by componentwise conversion.

double4x4(uint4x4)	
Return a double4x4 matrix constructed from a uint4x4 matrix by componentwise conversion.

down()	
Unity's down axis (0, -1, 0).

exp(Double)	
Returns the base-e exponential of x.

exp(Single)	
Returns the base-e exponential of x.

exp(double2)	
Returns the componentwise base-e exponential of x.

exp(double3)	
Returns the componentwise base-e exponential of x.

exp(double4)	
Returns the componentwise base-e exponential of x.

exp(float2)	
Returns the componentwise base-e exponential of x.

exp(float3)	
Returns the componentwise base-e exponential of x.

exp(float4)	
Returns the componentwise base-e exponential of x.

exp(quaternion)	
Returns the natural exponent of a quaternion.

exp10(Double)	
Returns the base-10 exponential of x.

exp10(Single)	
Returns the base-10 exponential of x.

exp10(double2)	
Returns the componentwise base-10 exponential of x.

exp10(double3)	
Returns the componentwise base-10 exponential of x.

exp10(double4)	
Returns the componentwise base-10 exponential of x.

exp10(float2)	
Returns the componentwise base-10 exponential of x.

exp10(float3)	
Returns the componentwise base-10 exponential of x.

exp10(float4)	
Returns the componentwise base-10 exponential of x.

exp2(Double)	
Returns the base-2 exponential of x.

exp2(Single)	
Returns the base-2 exponential of x.

exp2(double2)	
Returns the componentwise base-2 exponential of x.

exp2(double3)	
Returns the componentwise base-2 exponential of x.

exp2(double4)	
Returns the componentwise base-2 exponential of x.

exp2(float2)	
Returns the componentwise base-2 exponential of x.

exp2(float3)	
Returns the componentwise base-2 exponential of x.

exp2(float4)	
Returns the componentwise base-2 exponential of x.

f16tof32(UInt32)	
Returns the floating point representation of a half-precision floating point value.

f16tof32(uint2)	
Returns the floating point representation of a half-precision floating point vector.

f16tof32(uint3)	
Returns the floating point representation of a half-precision floating point vector.

f16tof32(uint4)	
Returns the floating point representation of a half-precision floating point vector.

f32tof16(Single)	
Returns the result converting a float value to its nearest half-precision floating point representation.

f32tof16(float2)	
Returns the result of a componentwise conversion of a float2 vector to its nearest half-precision floating point representation.

f32tof16(float3)	
Returns the result of a componentwise conversion of a float3 vector to its nearest half-precision floating point representation.

f32tof16(float4)	
Returns the result of a componentwise conversion of a float4 vector to its nearest half-precision floating point representation.

faceforward(double2, double2, double2)	
Conditionally flips a vector n if two vectors i and ng are pointing in the same direction. Returns n if dot(i, ng) < 0, -n otherwise.

faceforward(double3, double3, double3)	
Conditionally flips a vector n if two vectors i and ng are pointing in the same direction. Returns n if dot(i, ng) < 0, -n otherwise.

faceforward(double4, double4, double4)	
Conditionally flips a vector n if two vectors i and ng are pointing in the same direction. Returns n if dot(i, ng) < 0, -n otherwise.

faceforward(float2, float2, float2)	
Conditionally flips a vector n if two vectors i and ng are pointing in the same direction. Returns n if dot(i, ng) < 0, -n otherwise.

faceforward(float3, float3, float3)	
Conditionally flips a vector n if two vectors i and ng are pointing in the same direction. Returns n if dot(i, ng) < 0, -n otherwise.

faceforward(float4, float4, float4)	
Conditionally flips a vector n if two vectors i and ng are pointing in the same direction. Returns n if dot(i, ng) < 0, -n otherwise.

fastinverse(double3x4)	
Fast matrix inverse for rigid transforms (orthonormal basis and translation)

fastinverse(double4x4)	
Fast matrix inverse for rigid transforms (orthonormal basis and translation)

fastinverse(float3x4)	
Fast matrix inverse for rigid transforms (orthonormal basis and translation)

fastinverse(float4x4)	
Fast matrix inverse for rigid transforms (orthonormal basis and translation)

float2(Boolean)	
Returns a float2 vector constructed from a single bool value by converting it to float and assigning it to every component.

float2(Double)	
Returns a float2 vector constructed from a single double value by converting it to float and assigning it to every component.

float2(Int32)	
Returns a float2 vector constructed from a single int value by converting it to float and assigning it to every component.

float2(Single)	
Returns a float2 vector constructed from a single float value by assigning it to every component.

float2(Single, Single)	
Returns a float2 vector constructed from two float values.

float2(UInt32)	
Returns a float2 vector constructed from a single uint value by converting it to float and assigning it to every component.

float2(bool2)	
Return a float2 vector constructed from a bool2 vector by componentwise conversion.

float2(double2)	
Return a float2 vector constructed from a double2 vector by componentwise conversion.

float2(float2)	
Returns a float2 vector constructed from a float2 vector.

float2(half)	
Returns a float2 vector constructed from a single half value by converting it to float and assigning it to every component.

float2(half2)	
Return a float2 vector constructed from a half2 vector by componentwise conversion.

float2(int2)	
Return a float2 vector constructed from a int2 vector by componentwise conversion.

float2(uint2)	
Return a float2 vector constructed from a uint2 vector by componentwise conversion.

float2x2(Boolean)	
Returns a float2x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float2x2(Double)	
Returns a float2x2 matrix constructed from a single double value by converting it to float and assigning it to every component.

float2x2(Int32)	
Returns a float2x2 matrix constructed from a single int value by converting it to float and assigning it to every component.

float2x2(Single)	
Returns a float2x2 matrix constructed from a single float value by assigning it to every component.

float2x2(Single, Single, Single, Single)	
Returns a float2x2 matrix constructed from from 4 float values given in row-major order.

float2x2(UInt32)	
Returns a float2x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float2x2(bool2x2)	
Return a float2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.

float2x2(double2x2)	
Return a float2x2 matrix constructed from a double2x2 matrix by componentwise conversion.

float2x2(float2, float2)	
Returns a float2x2 matrix constructed from two float2 vectors.

float2x2(int2x2)	
Return a float2x2 matrix constructed from a int2x2 matrix by componentwise conversion.

float2x2(uint2x2)	
Return a float2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.

float2x3(Boolean)	
Returns a float2x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float2x3(Double)	
Returns a float2x3 matrix constructed from a single double value by converting it to float and assigning it to every component.

float2x3(Int32)	
Returns a float2x3 matrix constructed from a single int value by converting it to float and assigning it to every component.

float2x3(Single)	
Returns a float2x3 matrix constructed from a single float value by assigning it to every component.

float2x3(Single, Single, Single, Single, Single, Single)	
Returns a float2x3 matrix constructed from from 6 float values given in row-major order.

float2x3(UInt32)	
Returns a float2x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float2x3(bool2x3)	
Return a float2x3 matrix constructed from a bool2x3 matrix by componentwise conversion.

float2x3(double2x3)	
Return a float2x3 matrix constructed from a double2x3 matrix by componentwise conversion.

float2x3(float2, float2, float2)	
Returns a float2x3 matrix constructed from three float2 vectors.

float2x3(int2x3)	
Return a float2x3 matrix constructed from a int2x3 matrix by componentwise conversion.

float2x3(uint2x3)	
Return a float2x3 matrix constructed from a uint2x3 matrix by componentwise conversion.

float2x4(Boolean)	
Returns a float2x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float2x4(Double)	
Returns a float2x4 matrix constructed from a single double value by converting it to float and assigning it to every component.

float2x4(Int32)	
Returns a float2x4 matrix constructed from a single int value by converting it to float and assigning it to every component.

float2x4(Single)	
Returns a float2x4 matrix constructed from a single float value by assigning it to every component.

float2x4(Single, Single, Single, Single, Single, Single, Single, Single)	
Returns a float2x4 matrix constructed from from 8 float values given in row-major order.

float2x4(UInt32)	
Returns a float2x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float2x4(bool2x4)	
Return a float2x4 matrix constructed from a bool2x4 matrix by componentwise conversion.

float2x4(double2x4)	
Return a float2x4 matrix constructed from a double2x4 matrix by componentwise conversion.

float2x4(float2, float2, float2, float2)	
Returns a float2x4 matrix constructed from four float2 vectors.

float2x4(int2x4)	
Return a float2x4 matrix constructed from a int2x4 matrix by componentwise conversion.

float2x4(uint2x4)	
Return a float2x4 matrix constructed from a uint2x4 matrix by componentwise conversion.

float3(Boolean)	
Returns a float3 vector constructed from a single bool value by converting it to float and assigning it to every component.

float3(Double)	
Returns a float3 vector constructed from a single double value by converting it to float and assigning it to every component.

float3(Int32)	
Returns a float3 vector constructed from a single int value by converting it to float and assigning it to every component.

float3(Single)	
Returns a float3 vector constructed from a single float value by assigning it to every component.

float3(Single, Single, Single)	
Returns a float3 vector constructed from three float values.

float3(Single, float2)	
Returns a float3 vector constructed from a float value and a float2 vector.

float3(UInt32)	
Returns a float3 vector constructed from a single uint value by converting it to float and assigning it to every component.

float3(bool3)	
Return a float3 vector constructed from a bool3 vector by componentwise conversion.

float3(double3)	
Return a float3 vector constructed from a double3 vector by componentwise conversion.

float3(float2, Single)	
Returns a float3 vector constructed from a float2 vector and a float value.

float3(float3)	
Returns a float3 vector constructed from a float3 vector.

float3(half)	
Returns a float3 vector constructed from a single half value by converting it to float and assigning it to every component.

float3(half3)	
Return a float3 vector constructed from a half3 vector by componentwise conversion.

float3(int3)	
Return a float3 vector constructed from a int3 vector by componentwise conversion.

float3(uint3)	
Return a float3 vector constructed from a uint3 vector by componentwise conversion.

float3x2(Boolean)	
Returns a float3x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float3x2(Double)	
Returns a float3x2 matrix constructed from a single double value by converting it to float and assigning it to every component.

float3x2(Int32)	
Returns a float3x2 matrix constructed from a single int value by converting it to float and assigning it to every component.

float3x2(Single)	
Returns a float3x2 matrix constructed from a single float value by assigning it to every component.

float3x2(Single, Single, Single, Single, Single, Single)	
Returns a float3x2 matrix constructed from from 6 float values given in row-major order.

float3x2(UInt32)	
Returns a float3x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float3x2(bool3x2)	
Return a float3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.

float3x2(double3x2)	
Return a float3x2 matrix constructed from a double3x2 matrix by componentwise conversion.

float3x2(float3, float3)	
Returns a float3x2 matrix constructed from two float3 vectors.

float3x2(int3x2)	
Return a float3x2 matrix constructed from a int3x2 matrix by componentwise conversion.

float3x2(uint3x2)	
Return a float3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.

float3x3(Boolean)	
Returns a float3x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float3x3(Double)	
Returns a float3x3 matrix constructed from a single double value by converting it to float and assigning it to every component.

float3x3(Int32)	
Returns a float3x3 matrix constructed from a single int value by converting it to float and assigning it to every component.

float3x3(Single)	
Returns a float3x3 matrix constructed from a single float value by assigning it to every component.

float3x3(Single, Single, Single, Single, Single, Single, Single, Single, Single)	
Returns a float3x3 matrix constructed from from 9 float values given in row-major order.

float3x3(UInt32)	
Returns a float3x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float3x3(bool3x3)	
Return a float3x3 matrix constructed from a bool3x3 matrix by componentwise conversion.

float3x3(double3x3)	
Return a float3x3 matrix constructed from a double3x3 matrix by componentwise conversion.

float3x3(float3, float3, float3)	
Returns a float3x3 matrix constructed from three float3 vectors.

float3x3(float4x4)	
Extracts a float3x3 from the upper left 3x3 of a float4x4.

float3x3(int3x3)	
Return a float3x3 matrix constructed from a int3x3 matrix by componentwise conversion.

float3x3(quaternion)	
Returns a float3x3 matrix constructed from a quaternion.

float3x3(uint3x3)	
Return a float3x3 matrix constructed from a uint3x3 matrix by componentwise conversion.

float3x4(Boolean)	
Returns a float3x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float3x4(Double)	
Returns a float3x4 matrix constructed from a single double value by converting it to float and assigning it to every component.

float3x4(Int32)	
Returns a float3x4 matrix constructed from a single int value by converting it to float and assigning it to every component.

float3x4(Single)	
Returns a float3x4 matrix constructed from a single float value by assigning it to every component.

float3x4(Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single)	
Returns a float3x4 matrix constructed from from 12 float values given in row-major order.

float3x4(UInt32)	
Returns a float3x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float3x4(bool3x4)	
Return a float3x4 matrix constructed from a bool3x4 matrix by componentwise conversion.

float3x4(double3x4)	
Return a float3x4 matrix constructed from a double3x4 matrix by componentwise conversion.

float3x4(float3, float3, float3, float3)	
Returns a float3x4 matrix constructed from four float3 vectors.

float3x4(int3x4)	
Return a float3x4 matrix constructed from a int3x4 matrix by componentwise conversion.

float3x4(uint3x4)	
Return a float3x4 matrix constructed from a uint3x4 matrix by componentwise conversion.

float4(Boolean)	
Returns a float4 vector constructed from a single bool value by converting it to float and assigning it to every component.

float4(Double)	
Returns a float4 vector constructed from a single double value by converting it to float and assigning it to every component.

float4(Int32)	
Returns a float4 vector constructed from a single int value by converting it to float and assigning it to every component.

float4(Single)	
Returns a float4 vector constructed from a single float value by assigning it to every component.

float4(Single, Single, Single, Single)	
Returns a float4 vector constructed from four float values.

float4(Single, Single, float2)	
Returns a float4 vector constructed from two float values and a float2 vector.

float4(Single, float2, Single)	
Returns a float4 vector constructed from a float value, a float2 vector and a float value.

float4(Single, float3)	
Returns a float4 vector constructed from a float value and a float3 vector.

float4(UInt32)	
Returns a float4 vector constructed from a single uint value by converting it to float and assigning it to every component.

float4(bool4)	
Return a float4 vector constructed from a bool4 vector by componentwise conversion.

float4(double4)	
Return a float4 vector constructed from a double4 vector by componentwise conversion.

float4(float2, Single, Single)	
Returns a float4 vector constructed from a float2 vector and two float values.

float4(float2, float2)	
Returns a float4 vector constructed from two float2 vectors.

float4(float3, Single)	
Returns a float4 vector constructed from a float3 vector and a float value.

float4(float4)	
Returns a float4 vector constructed from a float4 vector.

float4(half)	
Returns a float4 vector constructed from a single half value by converting it to float and assigning it to every component.

float4(half4)	
Return a float4 vector constructed from a half4 vector by componentwise conversion.

float4(int4)	
Return a float4 vector constructed from a int4 vector by componentwise conversion.

float4(uint4)	
Return a float4 vector constructed from a uint4 vector by componentwise conversion.

float4x2(Boolean)	
Returns a float4x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float4x2(Double)	
Returns a float4x2 matrix constructed from a single double value by converting it to float and assigning it to every component.

float4x2(Int32)	
Returns a float4x2 matrix constructed from a single int value by converting it to float and assigning it to every component.

float4x2(Single)	
Returns a float4x2 matrix constructed from a single float value by assigning it to every component.

float4x2(Single, Single, Single, Single, Single, Single, Single, Single)	
Returns a float4x2 matrix constructed from from 8 float values given in row-major order.

float4x2(UInt32)	
Returns a float4x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float4x2(bool4x2)	
Return a float4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.

float4x2(double4x2)	
Return a float4x2 matrix constructed from a double4x2 matrix by componentwise conversion.

float4x2(float4, float4)	
Returns a float4x2 matrix constructed from two float4 vectors.

float4x2(int4x2)	
Return a float4x2 matrix constructed from a int4x2 matrix by componentwise conversion.

float4x2(uint4x2)	
Return a float4x2 matrix constructed from a uint4x2 matrix by componentwise conversion.

float4x3(Boolean)	
Returns a float4x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float4x3(Double)	
Returns a float4x3 matrix constructed from a single double value by converting it to float and assigning it to every component.

float4x3(Int32)	
Returns a float4x3 matrix constructed from a single int value by converting it to float and assigning it to every component.

float4x3(Single)	
Returns a float4x3 matrix constructed from a single float value by assigning it to every component.

float4x3(Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single)	
Returns a float4x3 matrix constructed from from 12 float values given in row-major order.

float4x3(UInt32)	
Returns a float4x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float4x3(bool4x3)	
Return a float4x3 matrix constructed from a bool4x3 matrix by componentwise conversion.

float4x3(double4x3)	
Return a float4x3 matrix constructed from a double4x3 matrix by componentwise conversion.

float4x3(float4, float4, float4)	
Returns a float4x3 matrix constructed from three float4 vectors.

float4x3(int4x3)	
Return a float4x3 matrix constructed from a int4x3 matrix by componentwise conversion.

float4x3(uint4x3)	
Return a float4x3 matrix constructed from a uint4x3 matrix by componentwise conversion.

float4x4(Boolean)	
Returns a float4x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.

float4x4(Double)	
Returns a float4x4 matrix constructed from a single double value by converting it to float and assigning it to every component.

float4x4(Int32)	
Returns a float4x4 matrix constructed from a single int value by converting it to float and assigning it to every component.

float4x4(Single)	
Returns a float4x4 matrix constructed from a single float value by assigning it to every component.

float4x4(Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single, Single)	
Returns a float4x4 matrix constructed from from 16 float values given in row-major order.

float4x4(UInt32)	
Returns a float4x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.

float4x4(bool4x4)	
Return a float4x4 matrix constructed from a bool4x4 matrix by componentwise conversion.

float4x4(double4x4)	
Return a float4x4 matrix constructed from a double4x4 matrix by componentwise conversion.

float4x4(float3x3, float3)	
Returns a float4x4 constructed from a float3x3 rotation matrix and a float3 translation vector.

float4x4(float4, float4, float4, float4)	
Returns a float4x4 matrix constructed from four float4 vectors.

float4x4(int4x4)	
Return a float4x4 matrix constructed from a int4x4 matrix by componentwise conversion.

float4x4(quaternion, float3)	
Returns a float4x4 constructed from a quaternion and a float3 translation vector.

float4x4(RigidTransform)	
Returns a float4x4 constructed from a RigidTransform.

float4x4(uint4x4)	
Return a float4x4 matrix constructed from a uint4x4 matrix by componentwise conversion.

floor(Double)	
Returns the result of rounding a double value up to the nearest integral value less or equal to the original value.

floor(Single)	
Returns the result of rounding a float value up to the nearest integral value less or equal to the original value.

floor(double2)	
Returns the result of rounding each component of a double2 vector value down to the nearest value less or equal to the original value.

floor(double3)	
Returns the result of rounding each component of a double3 vector value down to the nearest value less or equal to the original value.

floor(double4)	
Returns the result of rounding each component of a double4 vector value down to the nearest value less or equal to the original value.

floor(float2)	
Returns the result of rounding each component of a float2 vector value down to the nearest value less or equal to the original value.

floor(float3)	
Returns the result of rounding each component of a float3 vector value down to the nearest value less or equal to the original value.

floor(float4)	
Returns the result of rounding each component of a float4 vector value down to the nearest value less or equal to the original value.

floorlog2(Int32)	
Computes the floor of the base-2 logarithm of x.

floorlog2(UInt32)	
Computes the floor of the base-2 logarithm of x.

floorlog2(int2)	
Computes the componentwise floor of the base-2 logarithm of x.

floorlog2(int3)	
Computes the componentwise floor of the base-2 logarithm of x.

floorlog2(int4)	
Computes the componentwise floor of the base-2 logarithm of x.

floorlog2(uint2)	
Computes the componentwise floor of the base-2 logarithm of x.

floorlog2(uint3)	
Computes the componentwise floor of the base-2 logarithm of x.

floorlog2(uint4)	
Computes the componentwise floor of the base-2 logarithm of x.

fmod(Double, Double)	
Returns the double precision floating point remainder of x/y.

fmod(Single, Single)	
Returns the floating point remainder of x/y.

fmod(double2, double2)	
Returns the componentwise double precision floating point remainder of x/y.

fmod(double3, double3)	
Returns the componentwise double precision floating point remainder of x/y.

fmod(double4, double4)	
Returns the componentwise double precision floating point remainder of x/y.

fmod(float2, float2)	
Returns the componentwise floating point remainder of x/y.

fmod(float3, float3)	
Returns the componentwise floating point remainder of x/y.

fmod(float4, float4)	
Returns the componentwise floating point remainder of x/y.

forward()	
Unity's forward axis (0, 0, 1).

forward(quaternion)	
Transforms the forward vector by a quaternion.

frac(Double)	
Returns the fractional part of a double value.

frac(Single)	
Returns the fractional part of a float value.

frac(double2)	
Returns the componentwise fractional parts of a double2 vector.

frac(double3)	
Returns the componentwise fractional parts of a double3 vector.

frac(double4)	
Returns the componentwise fractional parts of a double4 vector.

frac(float2)	
Returns the componentwise fractional parts of a float2 vector.

frac(float3)	
Returns the componentwise fractional parts of a float3 vector.

frac(float4)	
Returns the componentwise fractional parts of a float4 vector.

half(Double)	
Returns a half value constructed from a double value.

half(Single)	
Returns a half value constructed from a float value.

half(half)	
Returns a half value constructed from a half values.

half2(Double)	
Returns a half2 vector constructed from a single double value by converting it to half and assigning it to every component.

half2(Single)	
Returns a half2 vector constructed from a single float value by converting it to half and assigning it to every component.

half2(double2)	
Return a half2 vector constructed from a double2 vector by componentwise conversion.

half2(float2)	
Return a half2 vector constructed from a float2 vector by componentwise conversion.

half2(half)	
Returns a half2 vector constructed from a single half value by assigning it to every component.

half2(half, half)	
Returns a half2 vector constructed from two half values.

half2(half2)	
Returns a half2 vector constructed from a half2 vector.

half3(Double)	
Returns a half3 vector constructed from a single double value by converting it to half and assigning it to every component.

half3(Single)	
Returns a half3 vector constructed from a single float value by converting it to half and assigning it to every component.

half3(double3)	
Return a half3 vector constructed from a double3 vector by componentwise conversion.

half3(float3)	
Return a half3 vector constructed from a float3 vector by componentwise conversion.

half3(half)	
Returns a half3 vector constructed from a single half value by assigning it to every component.

half3(half, half, half)	
Returns a half3 vector constructed from three half values.

half3(half, half2)	
Returns a half3 vector constructed from a half value and a half2 vector.

half3(half2, half)	
Returns a half3 vector constructed from a half2 vector and a half value.

half3(half3)	
Returns a half3 vector constructed from a half3 vector.

half4(Double)	
Returns a half4 vector constructed from a single double value by converting it to half and assigning it to every component.

half4(Single)	
Returns a half4 vector constructed from a single float value by converting it to half and assigning it to every component.

half4(double4)	
Return a half4 vector constructed from a double4 vector by componentwise conversion.

half4(float4)	
Return a half4 vector constructed from a float4 vector by componentwise conversion.

half4(half)	
Returns a half4 vector constructed from a single half value by assigning it to every component.

half4(half, half, half, half)	
Returns a half4 vector constructed from four half values.

half4(half, half, half2)	
Returns a half4 vector constructed from two half values and a half2 vector.

half4(half, half2, half)	
Returns a half4 vector constructed from a half value, a half2 vector and a half value.

half4(half, half3)	
Returns a half4 vector constructed from a half value and a half3 vector.

half4(half2, half, half)	
Returns a half4 vector constructed from a half2 vector and two half values.

half4(half2, half2)	
Returns a half4 vector constructed from two half2 vectors.

half4(half3, half)	
Returns a half4 vector constructed from a half3 vector and a half value.

half4(half4)	
Returns a half4 vector constructed from a half4 vector.

hash(Void*, Int32, UInt32)	
Returns a uint hash from a block of memory using the xxhash32 algorithm. Can only be used in an unsafe context.

hash(bool2)	
Returns a uint hash code of a bool2 vector.

hash(bool2x2)	
Returns a uint hash code of a bool2x2 matrix.

hash(bool2x3)	
Returns a uint hash code of a bool2x3 matrix.

hash(bool2x4)	
Returns a uint hash code of a bool2x4 matrix.

hash(bool3)	
Returns a uint hash code of a bool3 vector.

hash(bool3x2)	
Returns a uint hash code of a bool3x2 matrix.

hash(bool3x3)	
Returns a uint hash code of a bool3x3 matrix.

hash(bool3x4)	
Returns a uint hash code of a bool3x4 matrix.

hash(bool4)	
Returns a uint hash code of a bool4 vector.

hash(bool4x2)	
Returns a uint hash code of a bool4x2 matrix.

hash(bool4x3)	
Returns a uint hash code of a bool4x3 matrix.

hash(bool4x4)	
Returns a uint hash code of a bool4x4 matrix.

hash(double2)	
Returns a uint hash code of a double2 vector.

hash(double2x2)	
Returns a uint hash code of a double2x2 matrix.

hash(double2x3)	
Returns a uint hash code of a double2x3 matrix.

hash(double2x4)	
Returns a uint hash code of a double2x4 matrix.

hash(double3)	
Returns a uint hash code of a double3 vector.

hash(double3x2)	
Returns a uint hash code of a double3x2 matrix.

hash(double3x3)	
Returns a uint hash code of a double3x3 matrix.

hash(double3x4)	
Returns a uint hash code of a double3x4 matrix.

hash(double4)	
Returns a uint hash code of a double4 vector.

hash(double4x2)	
Returns a uint hash code of a double4x2 matrix.

hash(double4x3)	
Returns a uint hash code of a double4x3 matrix.

hash(double4x4)	
Returns a uint hash code of a double4x4 matrix.

hash(float2)	
Returns a uint hash code of a float2 vector.

hash(float2x2)	
Returns a uint hash code of a float2x2 matrix.

hash(float2x3)	
Returns a uint hash code of a float2x3 matrix.

hash(float2x4)	
Returns a uint hash code of a float2x4 matrix.

hash(float3)	
Returns a uint hash code of a float3 vector.

hash(float3x2)	
Returns a uint hash code of a float3x2 matrix.

hash(float3x3)	
Returns a uint hash code of a float3x3 matrix.

hash(float3x4)	
Returns a uint hash code of a float3x4 matrix.

hash(float4)	
Returns a uint hash code of a float4 vector.

hash(float4x2)	
Returns a uint hash code of a float4x2 matrix.

hash(float4x3)	
Returns a uint hash code of a float4x3 matrix.

hash(float4x4)	
Returns a uint hash code of a float4x4 matrix.

hash(half)	
Returns a uint hash code of a half value.

hash(half2)	
Returns a uint hash code of a half2 vector.

hash(half3)	
Returns a uint hash code of a half3 vector.

hash(half4)	
Returns a uint hash code of a half4 vector.

hash(int2)	
Returns a uint hash code of a int2 vector.

hash(int2x2)	
Returns a uint hash code of a int2x2 matrix.

hash(int2x3)	
Returns a uint hash code of a int2x3 matrix.

hash(int2x4)	
Returns a uint hash code of a int2x4 matrix.

hash(int3)	
Returns a uint hash code of a int3 vector.

hash(int3x2)	
Returns a uint hash code of a int3x2 matrix.

hash(int3x3)	
Returns a uint hash code of a int3x3 matrix.

hash(int3x4)	
Returns a uint hash code of a int3x4 matrix.

hash(int4)	
Returns a uint hash code of a int4 vector.

hash(int4x2)	
Returns a uint hash code of a int4x2 matrix.

hash(int4x3)	
Returns a uint hash code of a int4x3 matrix.

hash(int4x4)	
Returns a uint hash code of a int4x4 matrix.

hash(quaternion)	
Returns a uint hash code of a quaternion.

hash(RigidTransform)	
Returns a uint hash code of a RigidTransform.

hash(uint2)	
Returns a uint hash code of a uint2 vector.

hash(uint2x2)	
Returns a uint hash code of a uint2x2 matrix.

hash(uint2x3)	
Returns a uint hash code of a uint2x3 matrix.

hash(uint2x4)	
Returns a uint hash code of a uint2x4 matrix.

hash(uint3)	
Returns a uint hash code of a uint3 vector.

hash(uint3x2)	
Returns a uint hash code of a uint3x2 matrix.

hash(uint3x3)	
Returns a uint hash code of a uint3x3 matrix.

hash(uint3x4)	
Returns a uint hash code of a uint3x4 matrix.

hash(uint4)	
Returns a uint hash code of a uint4 vector.

hash(uint4x2)	
Returns a uint hash code of a uint4x2 matrix.

hash(uint4x3)	
Returns a uint hash code of a uint4x3 matrix.

hash(uint4x4)	
Returns a uint hash code of a uint4x4 matrix.

hashwide(bool2)	
Returns a uint2 vector hash code of a bool2 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool2x2)	
Returns a uint2 vector hash code of a bool2x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool2x3)	
Returns a uint2 vector hash code of a bool2x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool2x4)	
Returns a uint2 vector hash code of a bool2x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool3)	
Returns a uint3 vector hash code of a bool3 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool3x2)	
Returns a uint3 vector hash code of a bool3x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool3x3)	
Returns a uint3 vector hash code of a bool3x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool3x4)	
Returns a uint3 vector hash code of a bool3x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool4)	
Returns a uint4 vector hash code of a bool4 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool4x2)	
Returns a uint4 vector hash code of a bool4x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool4x3)	
Returns a uint4 vector hash code of a bool4x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(bool4x4)	
Returns a uint4 vector hash code of a bool4x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double2)	
Returns a uint2 vector hash code of a double2 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double2x2)	
Returns a uint2 vector hash code of a double2x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double2x3)	
Returns a uint2 vector hash code of a double2x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double2x4)	
Returns a uint2 vector hash code of a double2x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double3)	
Returns a uint3 vector hash code of a double3 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double3x2)	
Returns a uint3 vector hash code of a double3x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double3x3)	
Returns a uint3 vector hash code of a double3x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double3x4)	
Returns a uint3 vector hash code of a double3x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double4)	
Returns a uint4 vector hash code of a double4 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double4x2)	
Returns a uint4 vector hash code of a double4x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double4x3)	
Returns a uint4 vector hash code of a double4x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(double4x4)	
Returns a uint4 vector hash code of a double4x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float2)	
Returns a uint2 vector hash code of a float2 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float2x2)	
Returns a uint2 vector hash code of a float2x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float2x3)	
Returns a uint2 vector hash code of a float2x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float2x4)	
Returns a uint2 vector hash code of a float2x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float3)	
Returns a uint3 vector hash code of a float3 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float3x2)	
Returns a uint3 vector hash code of a float3x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float3x3)	
Returns a uint3 vector hash code of a float3x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float3x4)	
Returns a uint3 vector hash code of a float3x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float4)	
Returns a uint4 vector hash code of a float4 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float4x2)	
Returns a uint4 vector hash code of a float4x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float4x3)	
Returns a uint4 vector hash code of a float4x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(float4x4)	
Returns a uint4 vector hash code of a float4x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(half2)	
Returns a uint2 vector hash code of a half2 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(half3)	
Returns a uint3 vector hash code of a half3 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(half4)	
Returns a uint4 vector hash code of a half4 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int2)	
Returns a uint2 vector hash code of a int2 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int2x2)	
Returns a uint2 vector hash code of a int2x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int2x3)	
Returns a uint2 vector hash code of a int2x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int2x4)	
Returns a uint2 vector hash code of a int2x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int3)	
Returns a uint3 vector hash code of a int3 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int3x2)	
Returns a uint3 vector hash code of a int3x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int3x3)	
Returns a uint3 vector hash code of a int3x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int3x4)	
Returns a uint3 vector hash code of a int3x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int4)	
Returns a uint4 vector hash code of a int4 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int4x2)	
Returns a uint4 vector hash code of a int4x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int4x3)	
Returns a uint4 vector hash code of a int4x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(int4x4)	
Returns a uint4 vector hash code of a int4x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(quaternion)	
Returns a uint4 vector hash code of a quaternion. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(RigidTransform)	
Returns a uint4 vector hash code of a RigidTransform. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint2)	
Returns a uint2 vector hash code of a uint2 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint2x2)	
Returns a uint2 vector hash code of a uint2x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint2x3)	
Returns a uint2 vector hash code of a uint2x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint2x4)	
Returns a uint2 vector hash code of a uint2x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint3)	
Returns a uint3 vector hash code of a uint3 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint3x2)	
Returns a uint3 vector hash code of a uint3x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint3x3)	
Returns a uint3 vector hash code of a uint3x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint3x4)	
Returns a uint3 vector hash code of a uint3x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint4)	
Returns a uint4 vector hash code of a uint4 vector. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint4x2)	
Returns a uint4 vector hash code of a uint4x2 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint4x3)	
Returns a uint4 vector hash code of a uint4x3 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

hashwide(uint4x4)	
Returns a uint4 vector hash code of a uint4x4 matrix. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash that are only reduced to a narrow uint hash at the very end instead of at every step.

int2(Boolean)	
Returns a int2 vector constructed from a single bool value by converting it to int and assigning it to every component.

int2(Double)	
Returns a int2 vector constructed from a single double value by converting it to int and assigning it to every component.

int2(Int32)	
Returns a int2 vector constructed from a single int value by assigning it to every component.

int2(Int32, Int32)	
Returns a int2 vector constructed from two int values.

int2(Single)	
Returns a int2 vector constructed from a single float value by converting it to int and assigning it to every component.

int2(UInt32)	
Returns a int2 vector constructed from a single uint value by converting it to int and assigning it to every component.

int2(bool2)	
Return a int2 vector constructed from a bool2 vector by componentwise conversion.

int2(double2)	
Return a int2 vector constructed from a double2 vector by componentwise conversion.

int2(float2)	
Return a int2 vector constructed from a float2 vector by componentwise conversion.

int2(int2)	
Returns a int2 vector constructed from an int2 vector.

int2(uint2)	
Return a int2 vector constructed from a uint2 vector by componentwise conversion.

int2x2(Boolean)	
Returns a int2x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int2x2(Double)	
Returns a int2x2 matrix constructed from a single double value by converting it to int and assigning it to every component.

int2x2(Int32)	
Returns a int2x2 matrix constructed from a single int value by assigning it to every component.

int2x2(Int32, Int32, Int32, Int32)	
Returns a int2x2 matrix constructed from from 4 int values given in row-major order.

int2x2(Single)	
Returns a int2x2 matrix constructed from a single float value by converting it to int and assigning it to every component.

int2x2(UInt32)	
Returns a int2x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int2x2(bool2x2)	
Return a int2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.

int2x2(double2x2)	
Return a int2x2 matrix constructed from a double2x2 matrix by componentwise conversion.

int2x2(float2x2)	
Return a int2x2 matrix constructed from a float2x2 matrix by componentwise conversion.

int2x2(int2, int2)	
Returns a int2x2 matrix constructed from two int2 vectors.

int2x2(uint2x2)	
Return a int2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.

int2x3(Boolean)	
Returns a int2x3 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int2x3(Double)	
Returns a int2x3 matrix constructed from a single double value by converting it to int and assigning it to every component.

int2x3(Int32)	
Returns a int2x3 matrix constructed from a single int value by assigning it to every component.

int2x3(Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int2x3 matrix constructed from from 6 int values given in row-major order.

int2x3(Single)	
Returns a int2x3 matrix constructed from a single float value by converting it to int and assigning it to every component.

int2x3(UInt32)	
Returns a int2x3 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int2x3(bool2x3)	
Return a int2x3 matrix constructed from a bool2x3 matrix by componentwise conversion.

int2x3(double2x3)	
Return a int2x3 matrix constructed from a double2x3 matrix by componentwise conversion.

int2x3(float2x3)	
Return a int2x3 matrix constructed from a float2x3 matrix by componentwise conversion.

int2x3(int2, int2, int2)	
Returns a int2x3 matrix constructed from three int2 vectors.

int2x3(uint2x3)	
Return a int2x3 matrix constructed from a uint2x3 matrix by componentwise conversion.

int2x4(Boolean)	
Returns a int2x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int2x4(Double)	
Returns a int2x4 matrix constructed from a single double value by converting it to int and assigning it to every component.

int2x4(Int32)	
Returns a int2x4 matrix constructed from a single int value by assigning it to every component.

int2x4(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int2x4 matrix constructed from from 8 int values given in row-major order.

int2x4(Single)	
Returns a int2x4 matrix constructed from a single float value by converting it to int and assigning it to every component.

int2x4(UInt32)	
Returns a int2x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int2x4(bool2x4)	
Return a int2x4 matrix constructed from a bool2x4 matrix by componentwise conversion.

int2x4(double2x4)	
Return a int2x4 matrix constructed from a double2x4 matrix by componentwise conversion.

int2x4(float2x4)	
Return a int2x4 matrix constructed from a float2x4 matrix by componentwise conversion.

int2x4(int2, int2, int2, int2)	
Returns a int2x4 matrix constructed from four int2 vectors.

int2x4(uint2x4)	
Return a int2x4 matrix constructed from a uint2x4 matrix by componentwise conversion.

int3(Boolean)	
Returns a int3 vector constructed from a single bool value by converting it to int and assigning it to every component.

int3(Double)	
Returns a int3 vector constructed from a single double value by converting it to int and assigning it to every component.

int3(Int32)	
Returns a int3 vector constructed from a single int value by assigning it to every component.

int3(Int32, Int32, Int32)	
Returns a int3 vector constructed from three int values.

int3(Int32, int2)	
Returns a int3 vector constructed from an int value and an int2 vector.

int3(Single)	
Returns a int3 vector constructed from a single float value by converting it to int and assigning it to every component.

int3(UInt32)	
Returns a int3 vector constructed from a single uint value by converting it to int and assigning it to every component.

int3(bool3)	
Return a int3 vector constructed from a bool3 vector by componentwise conversion.

int3(double3)	
Return a int3 vector constructed from a double3 vector by componentwise conversion.

int3(float3)	
Return a int3 vector constructed from a float3 vector by componentwise conversion.

int3(int2, Int32)	
Returns a int3 vector constructed from an int2 vector and an int value.

int3(int3)	
Returns a int3 vector constructed from an int3 vector.

int3(uint3)	
Return a int3 vector constructed from a uint3 vector by componentwise conversion.

int3x2(Boolean)	
Returns a int3x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int3x2(Double)	
Returns a int3x2 matrix constructed from a single double value by converting it to int and assigning it to every component.

int3x2(Int32)	
Returns a int3x2 matrix constructed from a single int value by assigning it to every component.

int3x2(Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int3x2 matrix constructed from from 6 int values given in row-major order.

int3x2(Single)	
Returns a int3x2 matrix constructed from a single float value by converting it to int and assigning it to every component.

int3x2(UInt32)	
Returns a int3x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int3x2(bool3x2)	
Return a int3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.

int3x2(double3x2)	
Return a int3x2 matrix constructed from a double3x2 matrix by componentwise conversion.

int3x2(float3x2)	
Return a int3x2 matrix constructed from a float3x2 matrix by componentwise conversion.

int3x2(int3, int3)	
Returns a int3x2 matrix constructed from two int3 vectors.

int3x2(uint3x2)	
Return a int3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.

int3x3(Boolean)	
Returns a int3x3 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int3x3(Double)	
Returns a int3x3 matrix constructed from a single double value by converting it to int and assigning it to every component.

int3x3(Int32)	
Returns a int3x3 matrix constructed from a single int value by assigning it to every component.

int3x3(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int3x3 matrix constructed from from 9 int values given in row-major order.

int3x3(Single)	
Returns a int3x3 matrix constructed from a single float value by converting it to int and assigning it to every component.

int3x3(UInt32)	
Returns a int3x3 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int3x3(bool3x3)	
Return a int3x3 matrix constructed from a bool3x3 matrix by componentwise conversion.

int3x3(double3x3)	
Return a int3x3 matrix constructed from a double3x3 matrix by componentwise conversion.

int3x3(float3x3)	
Return a int3x3 matrix constructed from a float3x3 matrix by componentwise conversion.

int3x3(int3, int3, int3)	
Returns a int3x3 matrix constructed from three int3 vectors.

int3x3(uint3x3)	
Return a int3x3 matrix constructed from a uint3x3 matrix by componentwise conversion.

int3x4(Boolean)	
Returns a int3x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int3x4(Double)	
Returns a int3x4 matrix constructed from a single double value by converting it to int and assigning it to every component.

int3x4(Int32)	
Returns a int3x4 matrix constructed from a single int value by assigning it to every component.

int3x4(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int3x4 matrix constructed from from 12 int values given in row-major order.

int3x4(Single)	
Returns a int3x4 matrix constructed from a single float value by converting it to int and assigning it to every component.

int3x4(UInt32)	
Returns a int3x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int3x4(bool3x4)	
Return a int3x4 matrix constructed from a bool3x4 matrix by componentwise conversion.

int3x4(double3x4)	
Return a int3x4 matrix constructed from a double3x4 matrix by componentwise conversion.

int3x4(float3x4)	
Return a int3x4 matrix constructed from a float3x4 matrix by componentwise conversion.

int3x4(int3, int3, int3, int3)	
Returns a int3x4 matrix constructed from four int3 vectors.

int3x4(uint3x4)	
Return a int3x4 matrix constructed from a uint3x4 matrix by componentwise conversion.

int4(Boolean)	
Returns a int4 vector constructed from a single bool value by converting it to int and assigning it to every component.

int4(Double)	
Returns a int4 vector constructed from a single double value by converting it to int and assigning it to every component.

int4(Int32)	
Returns a int4 vector constructed from a single int value by assigning it to every component.

int4(Int32, Int32, Int32, Int32)	
Returns a int4 vector constructed from four int values.

int4(Int32, Int32, int2)	
Returns a int4 vector constructed from two int values and an int2 vector.

int4(Int32, int2, Int32)	
Returns a int4 vector constructed from an int value, an int2 vector and an int value.

int4(Int32, int3)	
Returns a int4 vector constructed from an int value and an int3 vector.

int4(Single)	
Returns a int4 vector constructed from a single float value by converting it to int and assigning it to every component.

int4(UInt32)	
Returns a int4 vector constructed from a single uint value by converting it to int and assigning it to every component.

int4(bool4)	
Return a int4 vector constructed from a bool4 vector by componentwise conversion.

int4(double4)	
Return a int4 vector constructed from a double4 vector by componentwise conversion.

int4(float4)	
Return a int4 vector constructed from a float4 vector by componentwise conversion.

int4(int2, Int32, Int32)	
Returns a int4 vector constructed from an int2 vector and two int values.

int4(int2, int2)	
Returns a int4 vector constructed from two int2 vectors.

int4(int3, Int32)	
Returns a int4 vector constructed from an int3 vector and an int value.

int4(int4)	
Returns a int4 vector constructed from an int4 vector.

int4(uint4)	
Return a int4 vector constructed from a uint4 vector by componentwise conversion.

int4x2(Boolean)	
Returns a int4x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int4x2(Double)	
Returns a int4x2 matrix constructed from a single double value by converting it to int and assigning it to every component.

int4x2(Int32)	
Returns a int4x2 matrix constructed from a single int value by assigning it to every component.

int4x2(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int4x2 matrix constructed from from 8 int values given in row-major order.

int4x2(Single)	
Returns a int4x2 matrix constructed from a single float value by converting it to int and assigning it to every component.

int4x2(UInt32)	
Returns a int4x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int4x2(bool4x2)	
Return a int4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.

int4x2(double4x2)	
Return a int4x2 matrix constructed from a double4x2 matrix by componentwise conversion.

int4x2(float4x2)	
Return a int4x2 matrix constructed from a float4x2 matrix by componentwise conversion.

int4x2(int4, int4)	
Returns a int4x2 matrix constructed from two int4 vectors.

int4x2(uint4x2)	
Return a int4x2 matrix constructed from a uint4x2 matrix by componentwise conversion.

int4x3(Boolean)	
Returns a int4x3 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int4x3(Double)	
Returns a int4x3 matrix constructed from a single double value by converting it to int and assigning it to every component.

int4x3(Int32)	
Returns a int4x3 matrix constructed from a single int value by assigning it to every component.

int4x3(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int4x3 matrix constructed from from 12 int values given in row-major order.

int4x3(Single)	
Returns a int4x3 matrix constructed from a single float value by converting it to int and assigning it to every component.

int4x3(UInt32)	
Returns a int4x3 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int4x3(bool4x3)	
Return a int4x3 matrix constructed from a bool4x3 matrix by componentwise conversion.

int4x3(double4x3)	
Return a int4x3 matrix constructed from a double4x3 matrix by componentwise conversion.

int4x3(float4x3)	
Return a int4x3 matrix constructed from a float4x3 matrix by componentwise conversion.

int4x3(int4, int4, int4)	
Returns a int4x3 matrix constructed from three int4 vectors.

int4x3(uint4x3)	
Return a int4x3 matrix constructed from a uint4x3 matrix by componentwise conversion.

int4x4(Boolean)	
Returns a int4x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.

int4x4(Double)	
Returns a int4x4 matrix constructed from a single double value by converting it to int and assigning it to every component.

int4x4(Int32)	
Returns a int4x4 matrix constructed from a single int value by assigning it to every component.

int4x4(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)	
Returns a int4x4 matrix constructed from from 16 int values given in row-major order.

int4x4(Single)	
Returns a int4x4 matrix constructed from a single float value by converting it to int and assigning it to every component.

int4x4(UInt32)	
Returns a int4x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.

int4x4(bool4x4)	
Return a int4x4 matrix constructed from a bool4x4 matrix by componentwise conversion.

int4x4(double4x4)	
Return a int4x4 matrix constructed from a double4x4 matrix by componentwise conversion.

int4x4(float4x4)	
Return a int4x4 matrix constructed from a float4x4 matrix by componentwise conversion.

int4x4(int4, int4, int4, int4)	
Returns a int4x4 matrix constructed from four int4 vectors.

int4x4(uint4x4)	
Return a int4x4 matrix constructed from a uint4x4 matrix by componentwise conversion.

inverse(double2x2)	
Returns the double2x2 full inverse of a double2x2 matrix.

inverse(double3x3)	
Returns the double3x3 full inverse of a double3x3 matrix.

inverse(double4x4)	
Returns the double4x4 full inverse of a double4x4 matrix.

inverse(float2x2)	
Returns the float2x2 full inverse of a float2x2 matrix.

inverse(float3x3)	
Returns the float3x3 full inverse of a float3x3 matrix.

inverse(float4x4)	
Returns the float4x4 full inverse of a float4x4 matrix.

inverse(quaternion)	
Returns the inverse of a quaternion value.

inverse(RigidTransform)	
Returns the inverse of a RigidTransform.

isfinite(Double)	
Returns true if the input double is a finite floating point value, false otherwise.

isfinite(Single)	
Returns true if the input float is a finite floating point value, false otherwise.

isfinite(double2)	
Returns a bool2 indicating for each component of a double2 whether it is a finite floating point value.

isfinite(double3)	
Returns a bool3 indicating for each component of a double3 whether it is a finite floating point value.

isfinite(double4)	
Returns a bool4 indicating for each component of a double4 whether it is a finite floating point value.

isfinite(float2)	
Returns a bool2 indicating for each component of a float2 whether it is a finite floating point value.

isfinite(float3)	
Returns a bool3 indicating for each component of a float3 whether it is a finite floating point value.

isfinite(float4)	
Returns a bool4 indicating for each component of a float4 whether it is a finite floating point value.

isinf(Double)	
Returns true if the input double is an infinite floating point value, false otherwise.

isinf(Single)	
Returns true if the input float is an infinite floating point value, false otherwise.

isinf(double2)	
Returns a bool2 indicating for each component of a double2 whether it is an infinite floating point value.

isinf(double3)	
Returns a bool3 indicating for each component of a double3 whether it is an infinite floating point value.

isinf(double4)	
Returns a bool4 indicating for each component of a double4 whether it is an infinite floating point value.

isinf(float2)	
Returns a bool2 indicating for each component of a float2 whether it is an infinite floating point value.

isinf(float3)	
Returns a bool3 indicating for each component of a float3 whether it is an infinite floating point value.

isinf(float4)	
Returns a bool4 indicating for each component of a float4 whether it is an infinite floating point value.

isnan(Double)	
Returns true if the input double is a NaN (not a number) floating point value, false otherwise.

isnan(Single)	
Returns true if the input float is a NaN (not a number) floating point value, false otherwise.

isnan(double2)	
Returns a bool2 indicating for each component of a double2 whether it is a NaN (not a number) floating point value.

isnan(double3)	
Returns a bool3 indicating for each component of a double3 whether it is a NaN (not a number) floating point value.

isnan(double4)	
Returns a bool4 indicating for each component of a double4 whether it is a NaN (not a number) floating point value.

isnan(float2)	
Returns a bool2 indicating for each component of a float2 whether it is a NaN (not a number) floating point value.

isnan(float3)	
Returns a bool3 indicating for each component of a float3 whether it is a NaN (not a number) floating point value.

isnan(float4)	
Returns a bool4 indicating for each component of a float4 whether it is a NaN (not a number) floating point value.

ispow2(Int32)	
Checks if the input is a power of two.

ispow2(UInt32)	
Checks if the input is a power of two.

ispow2(int2)	
Checks if each component of the input is a power of two.

ispow2(int3)	
Checks if each component of the input is a power of two.

ispow2(int4)	
Checks if each component of the input is a power of two.

ispow2(uint2)	
Checks if each component of the input is a power of two.

ispow2(uint3)	
Checks if each component of the input is a power of two.

ispow2(uint4)	
Checks if each component of the input is a power of two.

left()	
Unity's left axis (-1, 0, 0).

length(Double)	
Returns the length of a double value. Equivalent to the absolute value.

length(Single)	
Returns the length of a float value. Equivalent to the absolute value.

length(double2)	
Returns the length of a double2 vector.

length(double3)	
Returns the length of a double3 vector.

length(double4)	
Returns the length of a double4 vector.

length(float2)	
Returns the length of a float2 vector.

length(float3)	
Returns the length of a float3 vector.

length(float4)	
Returns the length of a float4 vector.

length(quaternion)	
Returns the length of a quaternion.

lengthsq(Double)	
Returns the squared length of a double value. Equivalent to squaring the value.

lengthsq(Single)	
Returns the squared length of a float value. Equivalent to squaring the value.

lengthsq(double2)	
Returns the squared length of a double2 vector.

lengthsq(double3)	
Returns the squared length of a double3 vector.

lengthsq(double4)	
Returns the squared length of a double4 vector.

lengthsq(float2)	
Returns the squared length of a float2 vector.

lengthsq(float3)	
Returns the squared length of a float3 vector.

lengthsq(float4)	
Returns the squared length of a float4 vector.

lengthsq(quaternion)	
Returns the squared length of a quaternion.

lerp(Double, Double, Double)	
Returns the result of linearly interpolating from x to y using the interpolation parameter s.

lerp(Single, Single, Single)	
Returns the result of linearly interpolating from x to y using the interpolation parameter s.

lerp(double2, double2, Double)	
Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.

lerp(double2, double2, double2)	
Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.

lerp(double3, double3, Double)	
Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.

lerp(double3, double3, double3)	
Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.

lerp(double4, double4, Double)	
Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.

lerp(double4, double4, double4)	
Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.

lerp(float2, float2, Single)	
Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.

lerp(float2, float2, float2)	
Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.

lerp(float3, float3, Single)	
Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.

lerp(float3, float3, float3)	
Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.

lerp(float4, float4, Single)	
Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.

lerp(float4, float4, float4)	
Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.

log(Double)	
Returns the natural logarithm of a double value.

log(Single)	
Returns the natural logarithm of a float value.

log(double2)	
Returns the componentwise natural logarithm of a double2 vector.

log(double3)	
Returns the componentwise natural logarithm of a double3 vector.

log(double4)	
Returns the componentwise natural logarithm of a double4 vector.

log(float2)	
Returns the componentwise natural logarithm of a float2 vector.

log(float3)	
Returns the componentwise natural logarithm of a float3 vector.

log(float4)	
Returns the componentwise natural logarithm of a float4 vector.

log(quaternion)	
Returns the natural logarithm of a quaternion.

log10(Double)	
Returns the base-10 logarithm of a double value.

log10(Single)	
Returns the base-10 logarithm of a float value.

log10(double2)	
Returns the componentwise base-10 logarithm of a double2 vector.

log10(double3)	
Returns the componentwise base-10 logarithm of a double3 vector.

log10(double4)	
Returns the componentwise base-10 logarithm of a double4 vector.

log10(float2)	
Returns the componentwise base-10 logarithm of a float2 vector.

log10(float3)	
Returns the componentwise base-10 logarithm of a float3 vector.

log10(float4)	
Returns the componentwise base-10 logarithm of a float4 vector.

log2(Double)	
Returns the base-2 logarithm of a double value.

log2(Single)	
Returns the base-2 logarithm of a float value.

log2(double2)	
Returns the componentwise base-2 logarithm of a double2 vector.

log2(double3)	
Returns the componentwise base-2 logarithm of a double3 vector.

log2(double4)	
Returns the componentwise base-2 logarithm of a double4 vector.

log2(float2)	
Returns the componentwise base-2 logarithm of a float2 vector.

log2(float3)	
Returns the componentwise base-2 logarithm of a float3 vector.

log2(float4)	
Returns the componentwise base-2 logarithm of a float4 vector.

lzcnt(Int32)	
Returns the componentwise number of leading zeros in the binary representations of an int vector.

lzcnt(Int64)	
Returns number of leading zeros in the binary representations of a long value.

lzcnt(UInt32)	
Returns number of leading zeros in the binary representations of a uint value.

lzcnt(UInt64)	
Returns number of leading zeros in the binary representations of a ulong value.

lzcnt(int2)	
Returns the componentwise number of leading zeros in the binary representations of an int2 vector.

lzcnt(int3)	
Returns the componentwise number of leading zeros in the binary representations of an int3 vector.

lzcnt(int4)	
Returns the componentwise number of leading zeros in the binary representations of an int4 vector.

lzcnt(uint2)	
Returns the componentwise number of leading zeros in the binary representations of a uint2 vector.

lzcnt(uint3)	
Returns the componentwise number of leading zeros in the binary representations of a uint3 vector.

lzcnt(uint4)	
Returns the componentwise number of leading zeros in the binary representations of a uint4 vector.

mad(Double, Double, Double)	
Returns the result of a multiply-add operation (a * b + c) on 3 double values.

mad(Int32, Int32, Int32)	
Returns the result of a multiply-add operation (a * b + c) on 3 int values.

mad(Int64, Int64, Int64)	
Returns the result of a multiply-add operation (a * b + c) on 3 long values.

mad(Single, Single, Single)	
Returns the result of a multiply-add operation (a * b + c) on 3 float values.

mad(UInt32, UInt32, UInt32)	
Returns the result of a multiply-add operation (a * b + c) on 3 uint values.

mad(UInt64, UInt64, UInt64)	
Returns the result of a multiply-add operation (a * b + c) on 3 ulong values.

mad(double2, double2, double2)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 double2 vectors.

mad(double3, double3, double3)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 double3 vectors.

mad(double4, double4, double4)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 double4 vectors.

mad(float2, float2, float2)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 float2 vectors.

mad(float3, float3, float3)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 float3 vectors.

mad(float4, float4, float4)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 float4 vectors.

mad(int2, int2, int2)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 int2 vectors.

mad(int3, int3, int3)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 int3 vectors.

mad(int4, int4, int4)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 int4 vectors.

mad(uint2, uint2, uint2)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 uint2 vectors.

mad(uint3, uint3, uint3)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 uint3 vectors.

mad(uint4, uint4, uint4)	
Returns the result of a componentwise multiply-add operation (a * b + c) on 3 uint4 vectors.

max(Double, Double)	
Returns the maximum of two double values.

max(Int32, Int32)	
Returns the maximum of two int values.

max(Int64, Int64)	
Returns the maximum of two long values.

max(Single, Single)	
Returns the maximum of two float values.

max(UInt32, UInt32)	
Returns the maximum of two uint values.

max(UInt64, UInt64)	
Returns the maximum of two ulong values.

max(double2, double2)	
Returns the componentwise maximum of two double2 vectors.

max(double3, double3)	
Returns the componentwise maximum of two double3 vectors.

max(double4, double4)	
Returns the componentwise maximum of two double4 vectors.

max(float2, float2)	
Returns the componentwise maximum of two float2 vectors.

max(float3, float3)	
Returns the componentwise maximum of two float3 vectors.

max(float4, float4)	
Returns the componentwise maximum of two float4 vectors.

max(int2, int2)	
Returns the componentwise maximum of two int2 vectors.

max(int3, int3)	
Returns the componentwise maximum of two int3 vectors.

max(int4, int4)	
Returns the componentwise maximum of two int4 vectors.

max(uint2, uint2)	
Returns the componentwise maximum of two uint2 vectors.

max(uint3, uint3)	
Returns the componentwise maximum of two uint3 vectors.

max(uint4, uint4)	
Returns the componentwise maximum of two uint4 vectors.

min(Double, Double)	
Returns the minimum of two double values.

min(Int32, Int32)	
Returns the minimum of two int values.

min(Int64, Int64)	
Returns the minimum of two long values.

min(Single, Single)	
Returns the minimum of two float values.

min(UInt32, UInt32)	
Returns the minimum of two uint values.

min(UInt64, UInt64)	
Returns the minimum of two ulong values.

min(double2, double2)	
Returns the componentwise minimum of two double2 vectors.

min(double3, double3)	
Returns the componentwise minimum of two double3 vectors.

min(double4, double4)	
Returns the componentwise minimum of two double4 vectors.

min(float2, float2)	
Returns the componentwise minimum of two float2 vectors.

min(float3, float3)	
Returns the componentwise minimum of two float3 vectors.

min(float4, float4)	
Returns the componentwise minimum of two float4 vectors.

min(int2, int2)	
Returns the componentwise minimum of two int2 vectors.

min(int3, int3)	
Returns the componentwise minimum of two int3 vectors.

min(int4, int4)	
Returns the componentwise minimum of two int4 vectors.

min(uint2, uint2)	
Returns the componentwise minimum of two uint2 vectors.

min(uint3, uint3)	
Returns the componentwise minimum of two uint3 vectors.

min(uint4, uint4)	
Returns the componentwise minimum of two uint4 vectors.

modf(Double, out Double)	
Splits a double value into an integral part i and a fractional part that gets returned. Both parts take the sign of the input.

modf(Single, out Single)	
Splits a float value into an integral part i and a fractional part that gets returned. Both parts take the sign of the input.

modf(double2, out double2)	
Performs a componentwise split of a double2 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.

modf(double3, out double3)	
Performs a componentwise split of a double3 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.

modf(double4, out double4)	
Performs a componentwise split of a double4 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.

modf(float2, out float2)	
Performs a componentwise split of a float2 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.

modf(float3, out float3)	
Performs a componentwise split of a float3 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.

modf(float4, out float4)	
Performs a componentwise split of a float4 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.

mul(Double, Double)	
Returns the double value result of a matrix multiplication between a double value and a double value.

mul(Int32, Int32)	
Returns the int value result of a matrix multiplication between an int value and an int value.

mul(Single, Single)	
Returns the float value result of a matrix multiplication between a float value and a float value.

mul(UInt32, UInt32)	
Returns the uint value result of a matrix multiplication between a uint value and a uint value.

mul(double2, double2)	
Returns the double value result of a matrix multiplication between a double2 row vector and a double2 column vector.

mul(double2, double2x2)	
Returns the double2 row vector result of a matrix multiplication between a double2 row vector and a double2x2 matrix.

mul(double2, double2x3)	
Returns the double3 row vector result of a matrix multiplication between a double2 row vector and a double2x3 matrix.

mul(double2, double2x4)	
Returns the double4 row vector result of a matrix multiplication between a double2 row vector and a double2x4 matrix.

mul(double2x2, double2)	
Returns the double2 column vector result of a matrix multiplication between a double2x2 matrix and a double2 column vector.

mul(double2x2, double2x2)	
Returns the double2x2 matrix result of a matrix multiplication between a double2x2 matrix and a double2x2 matrix.

mul(double2x2, double2x3)	
Returns the double2x3 matrix result of a matrix multiplication between a double2x2 matrix and a double2x3 matrix.

mul(double2x2, double2x4)	
Returns the double2x4 matrix result of a matrix multiplication between a double2x2 matrix and a double2x4 matrix.

mul(double2x3, double3)	
Returns the double2 column vector result of a matrix multiplication between a double2x3 matrix and a double3 column vector.

mul(double2x3, double3x2)	
Returns the double2x2 matrix result of a matrix multiplication between a double2x3 matrix and a double3x2 matrix.

mul(double2x3, double3x3)	
Returns the double2x3 matrix result of a matrix multiplication between a double2x3 matrix and a double3x3 matrix.

mul(double2x3, double3x4)	
Returns the double2x4 matrix result of a matrix multiplication between a double2x3 matrix and a double3x4 matrix.

mul(double2x4, double4)	
Returns the double2 column vector result of a matrix multiplication between a double2x4 matrix and a double4 column vector.

mul(double2x4, double4x2)	
Returns the double2x2 matrix result of a matrix multiplication between a double2x4 matrix and a double4x2 matrix.

mul(double2x4, double4x3)	
Returns the double2x3 matrix result of a matrix multiplication between a double2x4 matrix and a double4x3 matrix.

mul(double2x4, double4x4)	
Returns the double2x4 matrix result of a matrix multiplication between a double2x4 matrix and a double4x4 matrix.

mul(double3, double3)	
Returns the double value result of a matrix multiplication between a double3 row vector and a double3 column vector.

mul(double3, double3x2)	
Returns the double2 row vector result of a matrix multiplication between a double3 row vector and a double3x2 matrix.

mul(double3, double3x3)	
Returns the double3 row vector result of a matrix multiplication between a double3 row vector and a double3x3 matrix.

mul(double3, double3x4)	
Returns the double4 row vector result of a matrix multiplication between a double3 row vector and a double3x4 matrix.

mul(double3x2, double2)	
Returns the double3 column vector result of a matrix multiplication between a double3x2 matrix and a double2 column vector.

mul(double3x2, double2x2)	
Returns the double3x2 matrix result of a matrix multiplication between a double3x2 matrix and a double2x2 matrix.

mul(double3x2, double2x3)	
Returns the double3x3 matrix result of a matrix multiplication between a double3x2 matrix and a double2x3 matrix.

mul(double3x2, double2x4)	
Returns the double3x4 matrix result of a matrix multiplication between a double3x2 matrix and a double2x4 matrix.

mul(double3x3, double3)	
Returns the double3 column vector result of a matrix multiplication between a double3x3 matrix and a double3 column vector.

mul(double3x3, double3x2)	
Returns the double3x2 matrix result of a matrix multiplication between a double3x3 matrix and a double3x2 matrix.

mul(double3x3, double3x3)	
Returns the double3x3 matrix result of a matrix multiplication between a double3x3 matrix and a double3x3 matrix.

mul(double3x3, double3x4)	
Returns the double3x4 matrix result of a matrix multiplication between a double3x3 matrix and a double3x4 matrix.

mul(double3x4, double4)	
Returns the double3 column vector result of a matrix multiplication between a double3x4 matrix and a double4 column vector.

mul(double3x4, double4x2)	
Returns the double3x2 matrix result of a matrix multiplication between a double3x4 matrix and a double4x2 matrix.

mul(double3x4, double4x3)	
Returns the double3x3 matrix result of a matrix multiplication between a double3x4 matrix and a double4x3 matrix.

mul(double3x4, double4x4)	
Returns the double3x4 matrix result of a matrix multiplication between a double3x4 matrix and a double4x4 matrix.

mul(double4, double4)	
Returns the double value result of a matrix multiplication between a double4 row vector and a double4 column vector.

mul(double4, double4x2)	
Returns the double2 row vector result of a matrix multiplication between a double4 row vector and a double4x2 matrix.

mul(double4, double4x3)	
Returns the double3 row vector result of a matrix multiplication between a double4 row vector and a double4x3 matrix.

mul(double4, double4x4)	
Returns the double4 row vector result of a matrix multiplication between a double4 row vector and a double4x4 matrix.

mul(double4x2, double2)	
Returns the double4 column vector result of a matrix multiplication between a double4x2 matrix and a double2 column vector.

mul(double4x2, double2x2)	
Returns the double4x2 matrix result of a matrix multiplication between a double4x2 matrix and a double2x2 matrix.

mul(double4x2, double2x3)	
Returns the double4x3 matrix result of a matrix multiplication between a double4x2 matrix and a double2x3 matrix.

mul(double4x2, double2x4)	
Returns the double4x4 matrix result of a matrix multiplication between a double4x2 matrix and a double2x4 matrix.

mul(double4x3, double3)	
Returns the double4 column vector result of a matrix multiplication between a double4x3 matrix and a double3 column vector.

mul(double4x3, double3x2)	
Returns the double4x2 matrix result of a matrix multiplication between a double4x3 matrix and a double3x2 matrix.

mul(double4x3, double3x3)	
Returns the double4x3 matrix result of a matrix multiplication between a double4x3 matrix and a double3x3 matrix.

mul(double4x3, double3x4)	
Returns the double4x4 matrix result of a matrix multiplication between a double4x3 matrix and a double3x4 matrix.

mul(double4x4, double4)	
Returns the double4 column vector result of a matrix multiplication between a double4x4 matrix and a double4 column vector.

mul(double4x4, double4x2)	
Returns the double4x2 matrix result of a matrix multiplication between a double4x4 matrix and a double4x2 matrix.

mul(double4x4, double4x3)	
Returns the double4x3 matrix result of a matrix multiplication between a double4x4 matrix and a double4x3 matrix.

mul(double4x4, double4x4)	
Returns the double4x4 matrix result of a matrix multiplication between a double4x4 matrix and a double4x4 matrix.

mul(float2, float2)	
Returns the float value result of a matrix multiplication between a float2 row vector and a float2 column vector.

mul(float2, float2x2)	
Returns the float2 row vector result of a matrix multiplication between a float2 row vector and a float2x2 matrix.

mul(float2, float2x3)	
Returns the float3 row vector result of a matrix multiplication between a float2 row vector and a float2x3 matrix.

mul(float2, float2x4)	
Returns the float4 row vector result of a matrix multiplication between a float2 row vector and a float2x4 matrix.

mul(float2x2, float2)	
Returns the float2 column vector result of a matrix multiplication between a float2x2 matrix and a float2 column vector.

mul(float2x2, float2x2)	
Returns the float2x2 matrix result of a matrix multiplication between a float2x2 matrix and a float2x2 matrix.

mul(float2x2, float2x3)	
Returns the float2x3 matrix result of a matrix multiplication between a float2x2 matrix and a float2x3 matrix.

mul(float2x2, float2x4)	
Returns the float2x4 matrix result of a matrix multiplication between a float2x2 matrix and a float2x4 matrix.

mul(float2x3, float3)	
Returns the float2 column vector result of a matrix multiplication between a float2x3 matrix and a float3 column vector.

mul(float2x3, float3x2)	
Returns the float2x2 matrix result of a matrix multiplication between a float2x3 matrix and a float3x2 matrix.

mul(float2x3, float3x3)	
Returns the float2x3 matrix result of a matrix multiplication between a float2x3 matrix and a float3x3 matrix.

mul(float2x3, float3x4)	
Returns the float2x4 matrix result of a matrix multiplication between a float2x3 matrix and a float3x4 matrix.

mul(float2x4, float4)	
Returns the float2 column vector result of a matrix multiplication between a float2x4 matrix and a float4 column vector.

mul(float2x4, float4x2)	
Returns the float2x2 matrix result of a matrix multiplication between a float2x4 matrix and a float4x2 matrix.

mul(float2x4, float4x3)	
Returns the float2x3 matrix result of a matrix multiplication between a float2x4 matrix and a float4x3 matrix.

mul(float2x4, float4x4)	
Returns the float2x4 matrix result of a matrix multiplication between a float2x4 matrix and a float4x4 matrix.

mul(float3, float3)	
Returns the float value result of a matrix multiplication between a float3 row vector and a float3 column vector.

mul(float3, float3x2)	
Returns the float2 row vector result of a matrix multiplication between a float3 row vector and a float3x2 matrix.

mul(float3, float3x3)	
Returns the float3 row vector result of a matrix multiplication between a float3 row vector and a float3x3 matrix.

mul(float3, float3x4)	
Returns the float4 row vector result of a matrix multiplication between a float3 row vector and a float3x4 matrix.

mul(float3x2, float2)	
Returns the float3 column vector result of a matrix multiplication between a float3x2 matrix and a float2 column vector.

mul(float3x2, float2x2)	
Returns the float3x2 matrix result of a matrix multiplication between a float3x2 matrix and a float2x2 matrix.

mul(float3x2, float2x3)	
Returns the float3x3 matrix result of a matrix multiplication between a float3x2 matrix and a float2x3 matrix.

mul(float3x2, float2x4)	
Returns the float3x4 matrix result of a matrix multiplication between a float3x2 matrix and a float2x4 matrix.

mul(float3x3, float3)	
Returns the float3 column vector result of a matrix multiplication between a float3x3 matrix and a float3 column vector.

mul(float3x3, float3x2)	
Returns the float3x2 matrix result of a matrix multiplication between a float3x3 matrix and a float3x2 matrix.

mul(float3x3, float3x3)	
Returns the float3x3 matrix result of a matrix multiplication between a float3x3 matrix and a float3x3 matrix.

mul(float3x3, float3x4)	
Returns the float3x4 matrix result of a matrix multiplication between a float3x3 matrix and a float3x4 matrix.

mul(float3x4, float4)	
Returns the float3 column vector result of a matrix multiplication between a float3x4 matrix and a float4 column vector.

mul(float3x4, float4x2)	
Returns the float3x2 matrix result of a matrix multiplication between a float3x4 matrix and a float4x2 matrix.

mul(float3x4, float4x3)	
Returns the float3x3 matrix result of a matrix multiplication between a float3x4 matrix and a float4x3 matrix.

mul(float3x4, float4x4)	
Returns the float3x4 matrix result of a matrix multiplication between a float3x4 matrix and a float4x4 matrix.

mul(float4, float4)	
Returns the float value result of a matrix multiplication between a float4 row vector and a float4 column vector.

mul(float4, float4x2)	
Returns the float2 row vector result of a matrix multiplication between a float4 row vector and a float4x2 matrix.

mul(float4, float4x3)	
Returns the float3 row vector result of a matrix multiplication between a float4 row vector and a float4x3 matrix.

mul(float4, float4x4)	
Returns the float4 row vector result of a matrix multiplication between a float4 row vector and a float4x4 matrix.

mul(float4x2, float2)	
Returns the float4 column vector result of a matrix multiplication between a float4x2 matrix and a float2 column vector.

mul(float4x2, float2x2)	
Returns the float4x2 matrix result of a matrix multiplication between a float4x2 matrix and a float2x2 matrix.

mul(float4x2, float2x3)	
Returns the float4x3 matrix result of a matrix multiplication between a float4x2 matrix and a float2x3 matrix.

mul(float4x2, float2x4)	
Returns the float4x4 matrix result of a matrix multiplication between a float4x2 matrix and a float2x4 matrix.

mul(float4x3, float3)	
Returns the float4 column vector result of a matrix multiplication between a float4x3 matrix and a float3 column vector.

mul(float4x3, float3x2)	
Returns the float4x2 matrix result of a matrix multiplication between a float4x3 matrix and a float3x2 matrix.

mul(float4x3, float3x3)	
Returns the float4x3 matrix result of a matrix multiplication between a float4x3 matrix and a float3x3 matrix.

mul(float4x3, float3x4)	
Returns the float4x4 matrix result of a matrix multiplication between a float4x3 matrix and a float3x4 matrix.

mul(float4x4, float4)	
Returns the float4 column vector result of a matrix multiplication between a float4x4 matrix and a float4 column vector.

mul(float4x4, float4x2)	
Returns the float4x2 matrix result of a matrix multiplication between a float4x4 matrix and a float4x2 matrix.

mul(float4x4, float4x3)	
Returns the float4x3 matrix result of a matrix multiplication between a float4x4 matrix and a float4x3 matrix.

mul(float4x4, float4x4)	
Returns the float4x4 matrix result of a matrix multiplication between a float4x4 matrix and a float4x4 matrix.

mul(int2, int2)	
Returns the int value result of a matrix multiplication between an int2 row vector and an int2 column vector.

mul(int2, int2x2)	
Returns the int2 row vector result of a matrix multiplication between an int2 row vector and an int2x2 matrix.

mul(int2, int2x3)	
Returns the int3 row vector result of a matrix multiplication between an int2 row vector and an int2x3 matrix.

mul(int2, int2x4)	
Returns the int4 row vector result of a matrix multiplication between an int2 row vector and an int2x4 matrix.

mul(int2x2, int2)	
Returns the int2 column vector result of a matrix multiplication between an int2x2 matrix and an int2 column vector.

mul(int2x2, int2x2)	
Returns the int2x2 matrix result of a matrix multiplication between an int2x2 matrix and an int2x2 matrix.

mul(int2x2, int2x3)	
Returns the int2x3 matrix result of a matrix multiplication between an int2x2 matrix and an int2x3 matrix.

mul(int2x2, int2x4)	
Returns the int2x4 matrix result of a matrix multiplication between an int2x2 matrix and an int2x4 matrix.

mul(int2x3, int3)	
Returns the int2 column vector result of a matrix multiplication between an int2x3 matrix and an int3 column vector.

mul(int2x3, int3x2)	
Returns the int2x2 matrix result of a matrix multiplication between an int2x3 matrix and an int3x2 matrix.

mul(int2x3, int3x3)	
Returns the int2x3 matrix result of a matrix multiplication between an int2x3 matrix and an int3x3 matrix.

mul(int2x3, int3x4)	
Returns the int2x4 matrix result of a matrix multiplication between an int2x3 matrix and an int3x4 matrix.

mul(int2x4, int4)	
Returns the int2 column vector result of a matrix multiplication between an int2x4 matrix and an int4 column vector.

mul(int2x4, int4x2)	
Returns the int2x2 matrix result of a matrix multiplication between an int2x4 matrix and an int4x2 matrix.

mul(int2x4, int4x3)	
Returns the int2x3 matrix result of a matrix multiplication between an int2x4 matrix and an int4x3 matrix.

mul(int2x4, int4x4)	
Returns the int2x4 matrix result of a matrix multiplication between an int2x4 matrix and an int4x4 matrix.

mul(int3, int3)	
Returns the int value result of a matrix multiplication between an int3 row vector and an int3 column vector.

mul(int3, int3x2)	
Returns the int2 row vector result of a matrix multiplication between an int3 row vector and an int3x2 matrix.

mul(int3, int3x3)	
Returns the int3 row vector result of a matrix multiplication between an int3 row vector and an int3x3 matrix.

mul(int3, int3x4)	
Returns the int4 row vector result of a matrix multiplication between an int3 row vector and an int3x4 matrix.

mul(int3x2, int2)	
Returns the int3 column vector result of a matrix multiplication between an int3x2 matrix and an int2 column vector.

mul(int3x2, int2x2)	
Returns the int3x2 matrix result of a matrix multiplication between an int3x2 matrix and an int2x2 matrix.

mul(int3x2, int2x3)	
Returns the int3x3 matrix result of a matrix multiplication between an int3x2 matrix and an int2x3 matrix.

mul(int3x2, int2x4)	
Returns the int3x4 matrix result of a matrix multiplication between an int3x2 matrix and an int2x4 matrix.

mul(int3x3, int3)	
Returns the int3 column vector result of a matrix multiplication between an int3x3 matrix and an int3 column vector.

mul(int3x3, int3x2)	
Returns the int3x2 matrix result of a matrix multiplication between an int3x3 matrix and an int3x2 matrix.

mul(int3x3, int3x3)	
Returns the int3x3 matrix result of a matrix multiplication between an int3x3 matrix and an int3x3 matrix.

mul(int3x3, int3x4)	
Returns the int3x4 matrix result of a matrix multiplication between an int3x3 matrix and an int3x4 matrix.

mul(int3x4, int4)	
Returns the int3 column vector result of a matrix multiplication between an int3x4 matrix and an int4 column vector.

mul(int3x4, int4x2)	
Returns the int3x2 matrix result of a matrix multiplication between an int3x4 matrix and an int4x2 matrix.

mul(int3x4, int4x3)	
Returns the int3x3 matrix result of a matrix multiplication between an int3x4 matrix and an int4x3 matrix.

mul(int3x4, int4x4)	
Returns the int3x4 matrix result of a matrix multiplication between an int3x4 matrix and an int4x4 matrix.

mul(int4, int4)	
Returns the int value result of a matrix multiplication between an int4 row vector and an int4 column vector.

mul(int4, int4x2)	
Returns the int2 row vector result of a matrix multiplication between an int4 row vector and an int4x2 matrix.

mul(int4, int4x3)	
Returns the int3 row vector result of a matrix multiplication between an int4 row vector and an int4x3 matrix.

mul(int4, int4x4)	
Returns the int4 row vector result of a matrix multiplication between an int4 row vector and an int4x4 matrix.

mul(int4x2, int2)	
Returns the int4 column vector result of a matrix multiplication between an int4x2 matrix and an int2 column vector.

mul(int4x2, int2x2)	
Returns the int4x2 matrix result of a matrix multiplication between an int4x2 matrix and an int2x2 matrix.

mul(int4x2, int2x3)	
Returns the int4x3 matrix result of a matrix multiplication between an int4x2 matrix and an int2x3 matrix.

mul(int4x2, int2x4)	
Returns the int4x4 matrix result of a matrix multiplication between an int4x2 matrix and an int2x4 matrix.

mul(int4x3, int3)	
Returns the int4 column vector result of a matrix multiplication between an int4x3 matrix and an int3 column vector.

mul(int4x3, int3x2)	
Returns the int4x2 matrix result of a matrix multiplication between an int4x3 matrix and an int3x2 matrix.

mul(int4x3, int3x3)	
Returns the int4x3 matrix result of a matrix multiplication between an int4x3 matrix and an int3x3 matrix.

mul(int4x3, int3x4)	
Returns the int4x4 matrix result of a matrix multiplication between an int4x3 matrix and an int3x4 matrix.

mul(int4x4, int4)	
Returns the int4 column vector result of a matrix multiplication between an int4x4 matrix and an int4 column vector.

mul(int4x4, int4x2)	
Returns the int4x2 matrix result of a matrix multiplication between an int4x4 matrix and an int4x2 matrix.

mul(int4x4, int4x3)	
Returns the int4x3 matrix result of a matrix multiplication between an int4x4 matrix and an int4x3 matrix.

mul(int4x4, int4x4)	
Returns the int4x4 matrix result of a matrix multiplication between an int4x4 matrix and an int4x4 matrix.

mul(quaternion, float3)	
Returns the result of transforming a vector by a quaternion.

mul(quaternion, quaternion)	
Returns the result of transforming the quaternion b by the quaternion a.

mul(RigidTransform, float4)	
Returns the result of transforming a float4 homogeneous coordinate by a RigidTransform.

mul(RigidTransform, RigidTransform)	
Returns the result of transforming the RigidTransform b by the RigidTransform a.

mul(uint2, uint2)	
Returns the uint value result of a matrix multiplication between a uint2 row vector and a uint2 column vector.

mul(uint2, uint2x2)	
Returns the uint2 row vector result of a matrix multiplication between a uint2 row vector and a uint2x2 matrix.

mul(uint2, uint2x3)	
Returns the uint3 row vector result of a matrix multiplication between a uint2 row vector and a uint2x3 matrix.

mul(uint2, uint2x4)	
Returns the uint4 row vector result of a matrix multiplication between a uint2 row vector and a uint2x4 matrix.

mul(uint2x2, uint2)	
Returns the uint2 column vector result of a matrix multiplication between a uint2x2 matrix and a uint2 column vector.

mul(uint2x2, uint2x2)	
Returns the uint2x2 matrix result of a matrix multiplication between a uint2x2 matrix and a uint2x2 matrix.

mul(uint2x2, uint2x3)	
Returns the uint2x3 matrix result of a matrix multiplication between a uint2x2 matrix and a uint2x3 matrix.

mul(uint2x2, uint2x4)	
Returns the uint2x4 matrix result of a matrix multiplication between a uint2x2 matrix and a uint2x4 matrix.

mul(uint2x3, uint3)	
Returns the uint2 column vector result of a matrix multiplication between a uint2x3 matrix and a uint3 column vector.

mul(uint2x3, uint3x2)	
Returns the uint2x2 matrix result of a matrix multiplication between a uint2x3 matrix and a uint3x2 matrix.

mul(uint2x3, uint3x3)	
Returns the uint2x3 matrix result of a matrix multiplication between a uint2x3 matrix and a uint3x3 matrix.

mul(uint2x3, uint3x4)	
Returns the uint2x4 matrix result of a matrix multiplication between a uint2x3 matrix and a uint3x4 matrix.

mul(uint2x4, uint4)	
Returns the uint2 column vector result of a matrix multiplication between a uint2x4 matrix and a uint4 column vector.

mul(uint2x4, uint4x2)	
Returns the uint2x2 matrix result of a matrix multiplication between a uint2x4 matrix and a uint4x2 matrix.

mul(uint2x4, uint4x3)	
Returns the uint2x3 matrix result of a matrix multiplication between a uint2x4 matrix and a uint4x3 matrix.

mul(uint2x4, uint4x4)	
Returns the uint2x4 matrix result of a matrix multiplication between a uint2x4 matrix and a uint4x4 matrix.

mul(uint3, uint3)	
Returns the uint value result of a matrix multiplication between a uint3 row vector and a uint3 column vector.

mul(uint3, uint3x2)	
Returns the uint2 row vector result of a matrix multiplication between a uint3 row vector and a uint3x2 matrix.

mul(uint3, uint3x3)	
Returns the uint3 row vector result of a matrix multiplication between a uint3 row vector and a uint3x3 matrix.

mul(uint3, uint3x4)	
Returns the uint4 row vector result of a matrix multiplication between a uint3 row vector and a uint3x4 matrix.

mul(uint3x2, uint2)	
Returns the uint3 column vector result of a matrix multiplication between a uint3x2 matrix and a uint2 column vector.

mul(uint3x2, uint2x2)	
Returns the uint3x2 matrix result of a matrix multiplication between a uint3x2 matrix and a uint2x2 matrix.

mul(uint3x2, uint2x3)	
Returns the uint3x3 matrix result of a matrix multiplication between a uint3x2 matrix and a uint2x3 matrix.

mul(uint3x2, uint2x4)	
Returns the uint3x4 matrix result of a matrix multiplication between a uint3x2 matrix and a uint2x4 matrix.

mul(uint3x3, uint3)	
Returns the uint3 column vector result of a matrix multiplication between a uint3x3 matrix and a uint3 column vector.

mul(uint3x3, uint3x2)	
Returns the uint3x2 matrix result of a matrix multiplication between a uint3x3 matrix and a uint3x2 matrix.

mul(uint3x3, uint3x3)	
Returns the uint3x3 matrix result of a matrix multiplication between a uint3x3 matrix and a uint3x3 matrix.

mul(uint3x3, uint3x4)	
Returns the uint3x4 matrix result of a matrix multiplication between a uint3x3 matrix and a uint3x4 matrix.

mul(uint3x4, uint4)	
Returns the uint3 column vector result of a matrix multiplication between a uint3x4 matrix and a uint4 column vector.

mul(uint3x4, uint4x2)	
Returns the uint3x2 matrix result of a matrix multiplication between a uint3x4 matrix and a uint4x2 matrix.

mul(uint3x4, uint4x3)	
Returns the uint3x3 matrix result of a matrix multiplication between a uint3x4 matrix and a uint4x3 matrix.

mul(uint3x4, uint4x4)	
Returns the uint3x4 matrix result of a matrix multiplication between a uint3x4 matrix and a uint4x4 matrix.

mul(uint4, uint4)	
Returns the uint value result of a matrix multiplication between a uint4 row vector and a uint4 column vector.

mul(uint4, uint4x2)	
Returns the uint2 row vector result of a matrix multiplication between a uint4 row vector and a uint4x2 matrix.

mul(uint4, uint4x3)	
Returns the uint3 row vector result of a matrix multiplication between a uint4 row vector and a uint4x3 matrix.

mul(uint4, uint4x4)	
Returns the uint4 row vector result of a matrix multiplication between a uint4 row vector and a uint4x4 matrix.

mul(uint4x2, uint2)	
Returns the uint4 column vector result of a matrix multiplication between a uint4x2 matrix and a uint2 column vector.

mul(uint4x2, uint2x2)	
Returns the uint4x2 matrix result of a matrix multiplication between a uint4x2 matrix and a uint2x2 matrix.

mul(uint4x2, uint2x3)	
Returns the uint4x3 matrix result of a matrix multiplication between a uint4x2 matrix and a uint2x3 matrix.

mul(uint4x2, uint2x4)	
Returns the uint4x4 matrix result of a matrix multiplication between a uint4x2 matrix and a uint2x4 matrix.

mul(uint4x3, uint3)	
Returns the uint4 column vector result of a matrix multiplication between a uint4x3 matrix and a uint3 column vector.

mul(uint4x3, uint3x2)	
Returns the uint4x2 matrix result of a matrix multiplication between a uint4x3 matrix and a uint3x2 matrix.

mul(uint4x3, uint3x3)	
Returns the uint4x3 matrix result of a matrix multiplication between a uint4x3 matrix and a uint3x3 matrix.

mul(uint4x3, uint3x4)	
Returns the uint4x4 matrix result of a matrix multiplication between a uint4x3 matrix and a uint3x4 matrix.

mul(uint4x4, uint4)	
Returns the uint4 column vector result of a matrix multiplication between a uint4x4 matrix and a uint4 column vector.

mul(uint4x4, uint4x2)	
Returns the uint4x2 matrix result of a matrix multiplication between a uint4x4 matrix and a uint4x2 matrix.

mul(uint4x4, uint4x3)	
Returns the uint4x3 matrix result of a matrix multiplication between a uint4x4 matrix and a uint4x3 matrix.

mul(uint4x4, uint4x4)	
Returns the uint4x4 matrix result of a matrix multiplication between a uint4x4 matrix and a uint4x4 matrix.

nlerp(quaternion, quaternion, Single)	
Returns the result of a normalized linear interpolation between two quaternions q1 and a2 using an interpolation parameter t.

normalize(double2)	
Returns a normalized version of the double2 vector x by scaling it by 1 / length(x).

normalize(double3)	
Returns a normalized version of the double3 vector x by scaling it by 1 / length(x).

normalize(double4)	
Returns a normalized version of the double4 vector x by scaling it by 1 / length(x).

normalize(float2)	
Returns a normalized version of the float2 vector x by scaling it by 1 / length(x).

normalize(float3)	
Returns a normalized version of the float3 vector x by scaling it by 1 / length(x).

normalize(float4)	
Returns a normalized version of the float4 vector x by scaling it by 1 / length(x).

normalize(quaternion)	
Returns a normalized version of a quaternion q by scaling it by 1 / length(q).

normalizesafe(double2, double2)	
Returns a safe normalized version of the double4 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.

normalizesafe(double3, double3)	
Returns a safe normalized version of the double4 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.

normalizesafe(double4, double4)	
Returns a safe normalized version of the double4 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.

normalizesafe(float2, float2)	
Returns a safe normalized version of the float2 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.

normalizesafe(float3, float3)	
Returns a safe normalized version of the float3 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.

normalizesafe(float4, float4)	
Returns a safe normalized version of the float4 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.

normalizesafe(quaternion)	
Returns a safe normalized version of the q by scaling it by 1 / length(q). Returns the identity when 1 / length(q) does not produce a finite number.

normalizesafe(quaternion, quaternion)	
Returns a safe normalized version of the q by scaling it by 1 / length(q). Returns the given default value when 1 / length(q) does not produce a finite number.

orthonormalize(float3x3)	
Returns an orthonormalized version of a float3x3 matrix.

pow(Double, Double)	
Returns x raised to the power y.

pow(Single, Single)	
Returns x raised to the power y.

pow(double2, double2)	
Returns the componentwise result of raising x to the power y.

pow(double3, double3)	
Returns the componentwise result of raising x to the power y.

pow(double4, double4)	
Returns the componentwise result of raising x to the power y.

pow(float2, float2)	
Returns the componentwise result of raising x to the power y.

pow(float3, float3)	
Returns the componentwise result of raising x to the power y.

pow(float4, float4)	
Returns the componentwise result of raising x to the power y.

project(double2, double2)	
Compute vector projection of a onto b.

project(double3, double3)	
Compute vector projection of a onto b.

project(double4, double4)	
Compute vector projection of a onto b.

project(float2, float2)	
Compute vector projection of a onto b.

project(float3, float3)	
Compute vector projection of a onto b.

project(float4, float4)	
Compute vector projection of a onto b.

projectsafe(double2, double2, double2)	
Compute vector projection of a onto b. If result is not finite, then return the default value instead.

projectsafe(double3, double3, double3)	
Compute vector projection of a onto b. If result is not finite, then return the default value instead.

projectsafe(double4, double4, double4)	
Compute vector projection of a onto b. If result is not finite, then return the default value instead.

projectsafe(float2, float2, float2)	
Compute vector projection of a onto b. If result is not finite, then return the default value instead.

projectsafe(float3, float3, float3)	
Compute vector projection of a onto b. If result is not finite, then return the default value instead.

projectsafe(float4, float4, float4)	
Compute vector projection of a onto b. If result is not finite, then return the default value instead.

quaternion(Single, Single, Single, Single)	
Returns a quaternion constructed from four float values.

quaternion(float3x3)	
Returns a unit quaternion constructed from a float3x3 rotation matrix. The matrix must be orthonormal.

quaternion(float4)	
Returns a quaternion constructed from a float4 vector.

quaternion(float4x4)	
Returns a unit quaternion constructed from a float4x4 matrix. The matrix must be orthonormal.

radians(Double)	
Returns the result of converting a float value from degrees to radians.

radians(Single)	
Returns the result of converting a float value from degrees to radians.

radians(double2)	
Returns the result of a componentwise conversion of a float2 vector from degrees to radians.

radians(double3)	
Returns the result of a componentwise conversion of a float3 vector from degrees to radians.

radians(double4)	
Returns the result of a componentwise conversion of a float4 vector from degrees to radians.

radians(float2)	
Returns the result of a componentwise conversion of a float2 vector from degrees to radians.

radians(float3)	
Returns the result of a componentwise conversion of a float3 vector from degrees to radians.

radians(float4)	
Returns the result of a componentwise conversion of a float4 vector from degrees to radians.

rcp(Double)	
Returns the reciprocal a double value.

rcp(Single)	
Returns the reciprocal a float value.

rcp(double2)	
Returns the componentwise reciprocal a double2 vector.

rcp(double3)	
Returns the componentwise reciprocal a double3 vector.

rcp(double4)	
Returns the componentwise reciprocal a double4 vector.

rcp(float2)	
Returns the componentwise reciprocal a float2 vector.

rcp(float3)	
Returns the componentwise reciprocal a float3 vector.

rcp(float4)	
Returns the componentwise reciprocal a float4 vector.

reflect(double2, double2)	
Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0 * dot(i, n) * n.

reflect(double3, double3)	
Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0 * dot(i, n) * n.

reflect(double4, double4)	
Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0 * dot(i, n) * n.

reflect(float2, float2)	
Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.

reflect(float3, float3)	
Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.

reflect(float4, float4)	
Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.

refract(double2, double2, Double)	
Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.

refract(double3, double3, Double)	
Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.

refract(double4, double4, Double)	
Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.

refract(float2, float2, Single)	
Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.

refract(float3, float3, Single)	
Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.

refract(float4, float4, Single)	
Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.

remap(Double, Double, Double, Double, Double)	
Returns the result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(Single, Single, Single, Single, Single)	
Returns the result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(double2, double2, double2, double2, double2)	
Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(double3, double3, double3, double3, double3)	
Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(double4, double4, double4, double4, double4)	
Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(float2, float2, float2, float2, float2)	
Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(float3, float3, float3, float3, float3)	
Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

remap(float4, float4, float4, float4, float4)	
Returns the componentwise result of a non-clamping linear remapping of a value x from source range [a, b] to the destination range [c, d].

reversebits(Int32)	
Returns the result of performing a reversal of the bit pattern of an int value.

reversebits(Int64)	
Returns the result of performing a reversal of the bit pattern of a long value.

reversebits(UInt32)	
Returns the result of performing a reversal of the bit pattern of a uint value.

reversebits(UInt64)	
Returns the result of performing a reversal of the bit pattern of a ulong value.

reversebits(int2)	
Returns the result of performing a componentwise reversal of the bit pattern of an int2 vector.

reversebits(int3)	
Returns the result of performing a componentwise reversal of the bit pattern of an int3 vector.

reversebits(int4)	
Returns the result of performing a componentwise reversal of the bit pattern of an int4 vector.

reversebits(uint2)	
Returns the result of performing a componentwise reversal of the bit pattern of an uint2 vector.

reversebits(uint3)	
Returns the result of performing a componentwise reversal of the bit pattern of an uint3 vector.

reversebits(uint4)	
Returns the result of performing a componentwise reversal of the bit pattern of an uint4 vector.

right()	
Unity's right axis (1, 0, 0).

RigidTransform(float3x3, float3)	
Returns a RigidTransform constructed from a rotation represented by a float3x3 rotation matrix and a translation represented by a float3 vector.

RigidTransform(float4x4)	
Returns a RigidTransform constructed from a rotation represented by a float3x3 matrix and a translation represented by a float3 vector.

RigidTransform(quaternion, float3)	
Returns a RigidTransform constructed from a rotation represented by a unit quaternion and a translation represented by a float3 vector.

rol(Int32, Int32)	
Returns the result of rotating the bits of an int left by bits n.

rol(Int64, Int32)	
Returns the result of rotating the bits of a long left by bits n.

rol(UInt32, Int32)	
Returns the result of rotating the bits of a uint left by bits n.

rol(UInt64, Int32)	
Returns the result of rotating the bits of a ulong left by bits n.

rol(int2, Int32)	
Returns the componentwise result of rotating the bits of an int2 left by bits n.

rol(int3, Int32)	
Returns the componentwise result of rotating the bits of an int3 left by bits n.

rol(int4, Int32)	
Returns the componentwise result of rotating the bits of an int4 left by bits n.

rol(uint2, Int32)	
Returns the componentwise result of rotating the bits of a uint2 left by bits n.

rol(uint3, Int32)	
Returns the componentwise result of rotating the bits of a uint3 left by bits n.

rol(uint4, Int32)	
Returns the componentwise result of rotating the bits of a uint4 left by bits n.

ror(Int32, Int32)	
Returns the result of rotating the bits of an int right by bits n.

ror(Int64, Int32)	
Returns the result of rotating the bits of a long right by bits n.

ror(UInt32, Int32)	
Returns the result of rotating the bits of a uint right by bits n.

ror(UInt64, Int32)	
Returns the result of rotating the bits of a ulong right by bits n.

ror(int2, Int32)	
Returns the componentwise result of rotating the bits of an int2 right by bits n.

ror(int3, Int32)	
Returns the componentwise result of rotating the bits of an int3 right by bits n.

ror(int4, Int32)	
Returns the componentwise result of rotating the bits of an int4 right by bits n.

ror(uint2, Int32)	
Returns the componentwise result of rotating the bits of a uint2 right by bits n.

ror(uint3, Int32)	
Returns the componentwise result of rotating the bits of a uint3 right by bits n.

ror(uint4, Int32)	
Returns the componentwise result of rotating the bits of a uint4 right by bits n.

rotate(double4x4, double3)	
Return the result of rotating a double3 vector by a double4x4 matrix

rotate(float4x4, float3)	
Return the result of rotating a float3 vector by a float4x4 matrix

rotate(quaternion, float3)	
Returns the result of rotating a vector by a unit quaternion.

rotate(RigidTransform, float3)	
Returns the result of rotating a float3 vector by a RigidTransform.

round(Double)	
Returns the result of rounding a double value to the nearest integral value.

round(Single)	
Returns the result of rounding a float value to the nearest integral value.

round(double2)	
Returns the result of rounding each component of a double2 vector value to the nearest integral value.

round(double3)	
Returns the result of rounding each component of a double3 vector value to the nearest integral value.

round(double4)	
Returns the result of rounding each component of a double4 vector value to the nearest integral value.

round(float2)	
Returns the result of rounding each component of a float2 vector value to the nearest integral value.

round(float3)	
Returns the result of rounding each component of a float3 vector value to the nearest integral value.

round(float4)	
Returns the result of rounding each component of a float4 vector value to the nearest integral value.

rsqrt(Double)	
Returns the reciprocal square root of a double value.

rsqrt(Single)	
Returns the reciprocal square root of a float value.

rsqrt(double2)	
Returns the componentwise reciprocal square root of a double2 vector.

rsqrt(double3)	
Returns the componentwise reciprocal square root of a double3 vector.

rsqrt(double4)	
Returns the componentwise reciprocal square root of a double4 vector.

rsqrt(float2)	
Returns the componentwise reciprocal square root of a float2 vector.

rsqrt(float3)	
Returns the componentwise reciprocal square root of a float3 vector.

rsqrt(float4)	
Returns the componentwise reciprocal square root of a float4 vector

saturate(Double)	
Returns the result of clamping the double value x into the interval [0, 1].

saturate(Single)	
Returns the result of clamping the float value x into the interval [0, 1].

saturate(double2)	
Returns the result of a componentwise clamping of the double2 vector x into the interval [0, 1].

saturate(double3)	
Returns the result of a componentwise clamping of the double3 vector x into the interval [0, 1].

saturate(double4)	
Returns the result of a componentwise clamping of the double4 vector x into the interval [0, 1].

saturate(float2)	
Returns the result of a componentwise clamping of the float2 vector x into the interval [0, 1].

saturate(float3)	
Returns the result of a componentwise clamping of the float3 vector x into the interval [0, 1].

saturate(float4)	
Returns the result of a componentwise clamping of the float4 vector x into the interval [0, 1].

select(Double, Double, Boolean)	
Returns b if c is true, a otherwise.

select(Int32, Int32, Boolean)	
Returns b if c is true, a otherwise.

select(Int64, Int64, Boolean)	
Returns b if c is true, a otherwise.

select(Single, Single, Boolean)	
Returns b if c is true, a otherwise.

select(UInt32, UInt32, Boolean)	
Returns b if c is true, a otherwise.

select(UInt64, UInt64, Boolean)	
Returns b if c is true, a otherwise.

select(double2, double2, Boolean)	
Returns b if c is true, a otherwise.

select(double2, double2, bool2)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(double3, double3, Boolean)	
Returns b if c is true, a otherwise.

select(double3, double3, bool3)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(double4, double4, Boolean)	
Returns b if c is true, a otherwise.

select(double4, double4, bool4)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(float2, float2, Boolean)	
Returns b if c is true, a otherwise.

select(float2, float2, bool2)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(float3, float3, Boolean)	
Returns b if c is true, a otherwise.

select(float3, float3, bool3)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(float4, float4, Boolean)	
Returns b if c is true, a otherwise.

select(float4, float4, bool4)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(int2, int2, Boolean)	
Returns b if c is true, a otherwise.

select(int2, int2, bool2)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(int3, int3, Boolean)	
Returns b if c is true, a otherwise.

select(int3, int3, bool3)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(int4, int4, Boolean)	
Returns b if c is true, a otherwise.

select(int4, int4, bool4)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(uint2, uint2, Boolean)	
Returns b if c is true, a otherwise.

select(uint2, uint2, bool2)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(uint3, uint3, Boolean)	
Returns b if c is true, a otherwise.

select(uint3, uint3, bool3)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

select(uint4, uint4, Boolean)	
Returns b if c is true, a otherwise.

select(uint4, uint4, bool4)	
Returns a componentwise selection between two double4 vectors a and b based on a bool4 selection mask c. Per component, the component from b is selected when c is true, otherwise the component from a is selected.

shuffle(bool2, bool2, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool2 vectors into a bool value.

shuffle(bool2, bool2, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool2 vectors into a bool2 vector.

shuffle(bool2, bool2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool2 vectors into a bool3 vector.

shuffle(bool2, bool2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool2 vectors into a bool4 vector.

shuffle(bool3, bool3, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool3 vectors into a bool value.

shuffle(bool3, bool3, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool3 vectors into a bool2 vector.

shuffle(bool3, bool3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool3 vectors into a bool3 vector.

shuffle(bool3, bool3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool3 vectors into a bool4 vector.

shuffle(bool4, bool4, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool4 vectors into a bool value.

shuffle(bool4, bool4, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool4 vectors into a bool2 vector.

shuffle(bool4, bool4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool4 vectors into a bool3 vector.

shuffle(bool4, bool4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two bool4 vectors into a bool4 vector.

shuffle(double2, double2, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double2 vectors into a double value.

shuffle(double2, double2, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double2 vectors into a double2 vector.

shuffle(double2, double2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double2 vectors into a double3 vector.

shuffle(double2, double2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double2 vectors into a double4 vector.

shuffle(double3, double3, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double3 vectors into a double value.

shuffle(double3, double3, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double3 vectors into a double2 vector.

shuffle(double3, double3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double3 vectors into a double3 vector.

shuffle(double3, double3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double3 vectors into a double4 vector.

shuffle(double4, double4, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double4 vectors into a double value.

shuffle(double4, double4, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double4 vectors into a double2 vector.

shuffle(double4, double4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double4 vectors into a double3 vector.

shuffle(double4, double4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two double4 vectors into a double4 vector.

shuffle(float2, float2, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float2 vectors into a float value.

shuffle(float2, float2, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float2 vectors into a float2 vector.

shuffle(float2, float2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float2 vectors into a float3 vector.

shuffle(float2, float2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float2 vectors into a float4 vector.

shuffle(float3, float3, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float3 vectors into a float value.

shuffle(float3, float3, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float3 vectors into a float2 vector.

shuffle(float3, float3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float3 vectors into a float3 vector.

shuffle(float3, float3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float3 vectors into a float4 vector.

shuffle(float4, float4, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float4 vectors into a float value.

shuffle(float4, float4, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float4 vectors into a float2 vector.

shuffle(float4, float4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float4 vectors into a float3 vector.

shuffle(float4, float4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two float4 vectors into a float4 vector.

shuffle(int2, int2, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int2 vectors into an int value.

shuffle(int2, int2, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int2 vectors into an int2 vector.

shuffle(int2, int2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int2 vectors into an int3 vector.

shuffle(int2, int2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int2 vectors into an int4 vector.

shuffle(int3, int3, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int3 vectors into an int value.

shuffle(int3, int3, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int3 vectors into an int2 vector.

shuffle(int3, int3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int3 vectors into an int3 vector.

shuffle(int3, int3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int3 vectors into an int4 vector.

shuffle(int4, int4, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int4 vectors into an int value.

shuffle(int4, int4, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int4 vectors into an int2 vector.

shuffle(int4, int4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int4 vectors into an int3 vector.

shuffle(int4, int4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two int4 vectors into an int4 vector.

shuffle(uint2, uint2, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint2 vectors into a uint value.

shuffle(uint2, uint2, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint2 vectors into a uint2 vector.

shuffle(uint2, uint2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint2 vectors into a uint3 vector.

shuffle(uint2, uint2, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint2 vectors into a uint4 vector.

shuffle(uint3, uint3, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint3 vectors into a uint value.

shuffle(uint3, uint3, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint3 vectors into a uint2 vector.

shuffle(uint3, uint3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint3 vectors into a uint3 vector.

shuffle(uint3, uint3, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint3 vectors into a uint4 vector.

shuffle(uint4, uint4, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint4 vectors into a uint value.

shuffle(uint4, uint4, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint4 vectors into a uint2 vector.

shuffle(uint4, uint4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint4 vectors into a uint3 vector.

shuffle(uint4, uint4, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent, math.ShuffleComponent)	
Returns the result of specified shuffling of the components from two uint4 vectors into a uint4 vector.

sign(Double)	
Returns the sign of a double value. -1.0 if it is less than zero, 0.0 if it is zero and 1.0 if it greater than zero.

sign(Single)	
Returns the sign of a float value. -1.0f if it is less than zero, 0.0f if it is zero and 1.0f if it greater than zero.

sign(double2)	
Returns the componentwise sign of a double2 value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.

sign(double3)	
Returns the componentwise sign of a double3 value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.

sign(double4)	
Returns the componentwise sign of a double4 value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.

sign(float2)	
Returns the componentwise sign of a float2 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.

sign(float3)	
Returns the componentwise sign of a float3 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.

sign(float4)	
Returns the componentwise sign of a float4 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.

sin(Double)	
Returns the sine of a double value.

sin(Single)	
Returns the sine of a float value.

sin(double2)	
Returns the componentwise sine of a double2 vector.

sin(double3)	
Returns the componentwise sine of a double3 vector.

sin(double4)	
Returns the componentwise sine of a double4 vector.

sin(float2)	
Returns the componentwise sine of a float2 vector.

sin(float3)	
Returns the componentwise sine of a float3 vector.

sin(float4)	
Returns the componentwise sine of a float4 vector.

sincos(Double, out Double, out Double)	
Returns the sine and cosine of the input double value x through the out parameters s and c.

sincos(Single, out Single, out Single)	
Returns the sine and cosine of the input float value x through the out parameters s and c.

sincos(double2, out double2, out double2)	
Returns the componentwise sine and cosine of the input double2 vector x through the out parameters s and c.

sincos(double3, out double3, out double3)	
Returns the componentwise sine and cosine of the input double3 vector x through the out parameters s and c.

sincos(double4, out double4, out double4)	
Returns the componentwise sine and cosine of the input double4 vector x through the out parameters s and c.

sincos(float2, out float2, out float2)	
Returns the componentwise sine and cosine of the input float2 vector x through the out parameters s and c.

sincos(float3, out float3, out float3)	
Returns the componentwise sine and cosine of the input float3 vector x through the out parameters s and c.

sincos(float4, out float4, out float4)	
Returns the componentwise sine and cosine of the input float4 vector x through the out parameters s and c.

sinh(Double)	
Returns the hyperbolic sine of a double value.

sinh(Single)	
Returns the hyperbolic sine of a float value.

sinh(double2)	
Returns the componentwise hyperbolic sine of a double2 vector.

sinh(double3)	
Returns the componentwise hyperbolic sine of a double3 vector.

sinh(double4)	
Returns the componentwise hyperbolic sine of a double4 vector.

sinh(float2)	
Returns the componentwise hyperbolic sine of a float2 vector.

sinh(float3)	
Returns the componentwise hyperbolic sine of a float3 vector.

sinh(float4)	
Returns the componentwise hyperbolic sine of a float4 vector.

slerp(quaternion, quaternion, Single)	
Returns the result of a spherical interpolation between two quaternions q1 and a2 using an interpolation parameter t.

smoothstep(Double, Double, Double)	
Returns a smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].

smoothstep(Single, Single, Single)	
Returns a smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].

smoothstep(double2, double2, double2)	
Returns a componentwise smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].

smoothstep(double3, double3, double3)	
Returns a componentwise smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].

smoothstep(double4, double4, double4)	
Returns a componentwise smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].

smoothstep(float2, float2, float2)	
Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].

smoothstep(float3, float3, float3)	
Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].

smoothstep(float4, float4, float4)	
Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].

sqrt(Double)	
Returns the square root of a double value.

sqrt(Single)	
Returns the square root of a float value.

sqrt(double2)	
Returns the componentwise square root of a double2 vector.

sqrt(double3)	
Returns the componentwise square root of a double3 vector.

sqrt(double4)	
Returns the componentwise square root of a double4 vector.

sqrt(float2)	
Returns the componentwise square root of a float2 vector.

sqrt(float3)	
Returns the componentwise square root of a float3 vector.

sqrt(float4)	
Returns the componentwise square root of a float4 vector.

step(Double, Double)	
Returns the result of a step function where the result is 1.0f when x >= y and 0.0f otherwise.

step(Single, Single)	
Returns the result of a step function where the result is 1.0f when x >= y and 0.0f otherwise.

step(double2, double2)	
Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.

step(double3, double3)	
Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.

step(double4, double4)	
Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.

step(float2, float2)	
Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.

step(float3, float3)	
Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.

step(float4, float4)	
Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.

tan(Double)	
Returns the tangent of a double value.

tan(Single)	
Returns the tangent of a float value.

tan(double2)	
Returns the componentwise tangent of a double2 vector.

tan(double3)	
Returns the componentwise tangent of a double3 vector.

tan(double4)	
Returns the componentwise tangent of a double4 vector.

tan(float2)	
Returns the componentwise tangent of a float2 vector.

tan(float3)	
Returns the componentwise tangent of a float3 vector.

tan(float4)	
Returns the componentwise tangent of a float4 vector.

tanh(Double)	
Returns the hyperbolic tangent of a double value.

tanh(Single)	
Returns the hyperbolic tangent of a float value.

tanh(double2)	
Returns the componentwise hyperbolic tangent of a double2 vector.

tanh(double3)	
Returns the componentwise hyperbolic tangent of a double3 vector.

tanh(double4)	
Returns the componentwise hyperbolic tangent of a double4 vector.

tanh(float2)	
Returns the componentwise hyperbolic tangent of a float2 vector.

tanh(float3)	
Returns the componentwise hyperbolic tangent of a float3 vector.

tanh(float4)	
Returns the componentwise hyperbolic tangent of a float4 vector.

transform(double4x4, double3)	
Return the result of transforming a double3 point by a double4x4 matrix

transform(float4x4, float3)	
Return the result of transforming a float3 point by a float4x4 matrix

transform(RigidTransform, float3)	
Returns the result of transforming a float3 point by a RigidTransform.

transpose(bool2x2)	
Return the bool2x2 transpose of a bool2x2 matrix.

transpose(bool2x3)	
Return the bool3x2 transpose of a bool2x3 matrix.

transpose(bool2x4)	
Return the bool4x2 transpose of a bool2x4 matrix.

transpose(bool3x2)	
Return the bool2x3 transpose of a bool3x2 matrix.

transpose(bool3x3)	
Return the bool3x3 transpose of a bool3x3 matrix.

transpose(bool3x4)	
Return the bool4x3 transpose of a bool3x4 matrix.

transpose(bool4x2)	
Return the bool2x4 transpose of a bool4x2 matrix.

transpose(bool4x3)	
Return the bool3x4 transpose of a bool4x3 matrix.

transpose(bool4x4)	
Return the bool4x4 transpose of a bool4x4 matrix.

transpose(double2x2)	
Return the double2x2 transpose of a double2x2 matrix.

transpose(double2x3)	
Return the double3x2 transpose of a double2x3 matrix.

transpose(double2x4)	
Return the double4x2 transpose of a double2x4 matrix.

transpose(double3x2)	
Return the double2x3 transpose of a double3x2 matrix.

transpose(double3x3)	
Return the double3x3 transpose of a double3x3 matrix.

transpose(double3x4)	
Return the double4x3 transpose of a double3x4 matrix.

transpose(double4x2)	
Return the double2x4 transpose of a double4x2 matrix.

transpose(double4x3)	
Return the double3x4 transpose of a double4x3 matrix.

transpose(double4x4)	
Return the double4x4 transpose of a double4x4 matrix.

transpose(float2x2)	
Return the float2x2 transpose of a float2x2 matrix.

transpose(float2x3)	
Return the float3x2 transpose of a float2x3 matrix.

transpose(float2x4)	
Return the float4x2 transpose of a float2x4 matrix.

transpose(float3x2)	
Return the float2x3 transpose of a float3x2 matrix.

transpose(float3x3)	
Return the float3x3 transpose of a float3x3 matrix.

transpose(float3x4)	
Return the float4x3 transpose of a float3x4 matrix.

transpose(float4x2)	
Return the float2x4 transpose of a float4x2 matrix.

transpose(float4x3)	
Return the float3x4 transpose of a float4x3 matrix.

transpose(float4x4)	
Return the float4x4 transpose of a float4x4 matrix.

transpose(int2x2)	
Return the int2x2 transpose of a int2x2 matrix.

transpose(int2x3)	
Return the int3x2 transpose of a int2x3 matrix.

transpose(int2x4)	
Return the int4x2 transpose of a int2x4 matrix.

transpose(int3x2)	
Return the int2x3 transpose of a int3x2 matrix.

transpose(int3x3)	
Return the int3x3 transpose of a int3x3 matrix.

transpose(int3x4)	
Return the int4x3 transpose of a int3x4 matrix.

transpose(int4x2)	
Return the int2x4 transpose of a int4x2 matrix.

transpose(int4x3)	
Return the int3x4 transpose of a int4x3 matrix.

transpose(int4x4)	
Return the int4x4 transpose of a int4x4 matrix.

transpose(uint2x2)	
Return the uint2x2 transpose of a uint2x2 matrix.

transpose(uint2x3)	
Return the uint3x2 transpose of a uint2x3 matrix.

transpose(uint2x4)	
Return the uint4x2 transpose of a uint2x4 matrix.

transpose(uint3x2)	
Return the uint2x3 transpose of a uint3x2 matrix.

transpose(uint3x3)	
Return the uint3x3 transpose of a uint3x3 matrix.

transpose(uint3x4)	
Return the uint4x3 transpose of a uint3x4 matrix.

transpose(uint4x2)	
Return the uint2x4 transpose of a uint4x2 matrix.

transpose(uint4x3)	
Return the uint3x4 transpose of a uint4x3 matrix.

transpose(uint4x4)	
Return the uint4x4 transpose of a uint4x4 matrix.

trunc(Double)	
Returns the result of truncating a double value to an integral double value.

trunc(Single)	
Returns the result of truncating a float value to an integral float value.

trunc(double2)	
Returns the result of a componentwise truncation of a double2 value to an integral double2 value.

trunc(double3)	
Returns the result of a componentwise truncation of a double3 value to an integral double3 value.

trunc(double4)	
Returns the result of a componentwise truncation of a double4 value to an integral double4 value.

trunc(float2)	
Returns the result of a componentwise truncation of a float2 value to an integral float2 value.

trunc(float3)	
Returns the result of a componentwise truncation of a float3 value to an integral float3 value.

trunc(float4)	
Returns the result of a componentwise truncation of a float4 value to an integral float4 value.

tzcnt(Int32)	
Computes the trailing zero count in the binary representation of the input value.

tzcnt(Int64)	
Computes the trailing zero count in the binary representation of the input value.

tzcnt(UInt32)	
Computes the trailing zero count in the binary representation of the input value.

tzcnt(UInt64)	
Computes the trailing zero count in the binary representation of the input value.

tzcnt(int2)	
Computes the component-wise trailing zero count in the binary representation of the input value.

tzcnt(int3)	
Computes the component-wise trailing zero count in the binary representation of the input value.

tzcnt(int4)	
Computes the component-wise trailing zero count in the binary representation of the input value.

tzcnt(uint2)	
Computes the component-wise trailing zero count in the binary representation of the input value.

tzcnt(uint3)	
Computes the component-wise trailing zero count in the binary representation of the input value.

tzcnt(uint4)	
Computes the component-wise trailing zero count in the binary representation of the input value.

uint2(Boolean)	
Returns a uint2 vector constructed from a single bool value by converting it to uint and assigning it to every component.

uint2(Double)	
Returns a uint2 vector constructed from a single double value by converting it to uint and assigning it to every component.

uint2(Int32)	
Returns a uint2 vector constructed from a single int value by converting it to uint and assigning it to every component.

uint2(Single)	
Returns a uint2 vector constructed from a single float value by converting it to uint and assigning it to every component.

uint2(UInt32)	
Returns a uint2 vector constructed from a single uint value by assigning it to every component.

uint2(UInt32, UInt32)	
Returns a uint2 vector constructed from two uint values.

uint2(bool2)	
Return a uint2 vector constructed from a bool2 vector by componentwise conversion.

uint2(double2)	
Return a uint2 vector constructed from a double2 vector by componentwise conversion.

uint2(float2)	
Return a uint2 vector constructed from a float2 vector by componentwise conversion.

uint2(int2)	
Return a uint2 vector constructed from a int2 vector by componentwise conversion.

uint2(uint2)	
Returns a uint2 vector constructed from a uint2 vector.

uint2x2(Boolean)	
Returns a uint2x2 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint2x2(Double)	
Returns a uint2x2 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint2x2(Int32)	
Returns a uint2x2 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint2x2(Single)	
Returns a uint2x2 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint2x2(UInt32)	
Returns a uint2x2 matrix constructed from a single uint value by assigning it to every component.

uint2x2(UInt32, UInt32, UInt32, UInt32)	
Returns a uint2x2 matrix constructed from from 4 uint values given in row-major order.

uint2x2(bool2x2)	
Return a uint2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.

uint2x2(double2x2)	
Return a uint2x2 matrix constructed from a double2x2 matrix by componentwise conversion.

uint2x2(float2x2)	
Return a uint2x2 matrix constructed from a float2x2 matrix by componentwise conversion.

uint2x2(int2x2)	
Return a uint2x2 matrix constructed from a int2x2 matrix by componentwise conversion.

uint2x2(uint2, uint2)	
Returns a uint2x2 matrix constructed from two uint2 vectors.

uint2x3(Boolean)	
Returns a uint2x3 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint2x3(Double)	
Returns a uint2x3 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint2x3(Int32)	
Returns a uint2x3 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint2x3(Single)	
Returns a uint2x3 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint2x3(UInt32)	
Returns a uint2x3 matrix constructed from a single uint value by assigning it to every component.

uint2x3(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint2x3 matrix constructed from from 6 uint values given in row-major order.

uint2x3(bool2x3)	
Return a uint2x3 matrix constructed from a bool2x3 matrix by componentwise conversion.

uint2x3(double2x3)	
Return a uint2x3 matrix constructed from a double2x3 matrix by componentwise conversion.

uint2x3(float2x3)	
Return a uint2x3 matrix constructed from a float2x3 matrix by componentwise conversion.

uint2x3(int2x3)	
Return a uint2x3 matrix constructed from a int2x3 matrix by componentwise conversion.

uint2x3(uint2, uint2, uint2)	
Returns a uint2x3 matrix constructed from three uint2 vectors.

uint2x4(Boolean)	
Returns a uint2x4 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint2x4(Double)	
Returns a uint2x4 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint2x4(Int32)	
Returns a uint2x4 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint2x4(Single)	
Returns a uint2x4 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint2x4(UInt32)	
Returns a uint2x4 matrix constructed from a single uint value by assigning it to every component.

uint2x4(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint2x4 matrix constructed from from 8 uint values given in row-major order.

uint2x4(bool2x4)	
Return a uint2x4 matrix constructed from a bool2x4 matrix by componentwise conversion.

uint2x4(double2x4)	
Return a uint2x4 matrix constructed from a double2x4 matrix by componentwise conversion.

uint2x4(float2x4)	
Return a uint2x4 matrix constructed from a float2x4 matrix by componentwise conversion.

uint2x4(int2x4)	
Return a uint2x4 matrix constructed from a int2x4 matrix by componentwise conversion.

uint2x4(uint2, uint2, uint2, uint2)	
Returns a uint2x4 matrix constructed from four uint2 vectors.

uint3(Boolean)	
Returns a uint3 vector constructed from a single bool value by converting it to uint and assigning it to every component.

uint3(Double)	
Returns a uint3 vector constructed from a single double value by converting it to uint and assigning it to every component.

uint3(Int32)	
Returns a uint3 vector constructed from a single int value by converting it to uint and assigning it to every component.

uint3(Single)	
Returns a uint3 vector constructed from a single float value by converting it to uint and assigning it to every component.

uint3(UInt32)	
Returns a uint3 vector constructed from a single uint value by assigning it to every component.

uint3(UInt32, UInt32, UInt32)	
Returns a uint3 vector constructed from three uint values.

uint3(UInt32, uint2)	
Returns a uint3 vector constructed from a uint value and a uint2 vector.

uint3(bool3)	
Return a uint3 vector constructed from a bool3 vector by componentwise conversion.

uint3(double3)	
Return a uint3 vector constructed from a double3 vector by componentwise conversion.

uint3(float3)	
Return a uint3 vector constructed from a float3 vector by componentwise conversion.

uint3(int3)	
Return a uint3 vector constructed from a int3 vector by componentwise conversion.

uint3(uint2, UInt32)	
Returns a uint3 vector constructed from a uint2 vector and a uint value.

uint3(uint3)	
Returns a uint3 vector constructed from a uint3 vector.

uint3x2(Boolean)	
Returns a uint3x2 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint3x2(Double)	
Returns a uint3x2 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint3x2(Int32)	
Returns a uint3x2 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint3x2(Single)	
Returns a uint3x2 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint3x2(UInt32)	
Returns a uint3x2 matrix constructed from a single uint value by assigning it to every component.

uint3x2(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint3x2 matrix constructed from from 6 uint values given in row-major order.

uint3x2(bool3x2)	
Return a uint3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.

uint3x2(double3x2)	
Return a uint3x2 matrix constructed from a double3x2 matrix by componentwise conversion.

uint3x2(float3x2)	
Return a uint3x2 matrix constructed from a float3x2 matrix by componentwise conversion.

uint3x2(int3x2)	
Return a uint3x2 matrix constructed from a int3x2 matrix by componentwise conversion.

uint3x2(uint3, uint3)	
Returns a uint3x2 matrix constructed from two uint3 vectors.

uint3x3(Boolean)	
Returns a uint3x3 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint3x3(Double)	
Returns a uint3x3 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint3x3(Int32)	
Returns a uint3x3 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint3x3(Single)	
Returns a uint3x3 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint3x3(UInt32)	
Returns a uint3x3 matrix constructed from a single uint value by assigning it to every component.

uint3x3(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint3x3 matrix constructed from from 9 uint values given in row-major order.

uint3x3(bool3x3)	
Return a uint3x3 matrix constructed from a bool3x3 matrix by componentwise conversion.

uint3x3(double3x3)	
Return a uint3x3 matrix constructed from a double3x3 matrix by componentwise conversion.

uint3x3(float3x3)	
Return a uint3x3 matrix constructed from a float3x3 matrix by componentwise conversion.

uint3x3(int3x3)	
Return a uint3x3 matrix constructed from a int3x3 matrix by componentwise conversion.

uint3x3(uint3, uint3, uint3)	
Returns a uint3x3 matrix constructed from three uint3 vectors.

uint3x4(Boolean)	
Returns a uint3x4 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint3x4(Double)	
Returns a uint3x4 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint3x4(Int32)	
Returns a uint3x4 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint3x4(Single)	
Returns a uint3x4 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint3x4(UInt32)	
Returns a uint3x4 matrix constructed from a single uint value by assigning it to every component.

uint3x4(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint3x4 matrix constructed from from 12 uint values given in row-major order.

uint3x4(bool3x4)	
Return a uint3x4 matrix constructed from a bool3x4 matrix by componentwise conversion.

uint3x4(double3x4)	
Return a uint3x4 matrix constructed from a double3x4 matrix by componentwise conversion.

uint3x4(float3x4)	
Return a uint3x4 matrix constructed from a float3x4 matrix by componentwise conversion.

uint3x4(int3x4)	
Return a uint3x4 matrix constructed from a int3x4 matrix by componentwise conversion.

uint3x4(uint3, uint3, uint3, uint3)	
Returns a uint3x4 matrix constructed from four uint3 vectors.

uint4(Boolean)	
Returns a uint4 vector constructed from a single bool value by converting it to uint and assigning it to every component.

uint4(Double)	
Returns a uint4 vector constructed from a single double value by converting it to uint and assigning it to every component.

uint4(Int32)	
Returns a uint4 vector constructed from a single int value by converting it to uint and assigning it to every component.

uint4(Single)	
Returns a uint4 vector constructed from a single float value by converting it to uint and assigning it to every component.

uint4(UInt32)	
Returns a uint4 vector constructed from a single uint value by assigning it to every component.

uint4(UInt32, UInt32, UInt32, UInt32)	
Returns a uint4 vector constructed from four uint values.

uint4(UInt32, UInt32, uint2)	
Returns a uint4 vector constructed from two uint values and a uint2 vector.

uint4(UInt32, uint2, UInt32)	
Returns a uint4 vector constructed from a uint value, a uint2 vector and a uint value.

uint4(UInt32, uint3)	
Returns a uint4 vector constructed from a uint value and a uint3 vector.

uint4(bool4)	
Return a uint4 vector constructed from a bool4 vector by componentwise conversion.

uint4(double4)	
Return a uint4 vector constructed from a double4 vector by componentwise conversion.

uint4(float4)	
Return a uint4 vector constructed from a float4 vector by componentwise conversion.

uint4(int4)	
Return a uint4 vector constructed from a int4 vector by componentwise conversion.

uint4(uint2, UInt32, UInt32)	
Returns a uint4 vector constructed from a uint2 vector and two uint values.

uint4(uint2, uint2)	
Returns a uint4 vector constructed from two uint2 vectors.

uint4(uint3, UInt32)	
Returns a uint4 vector constructed from a uint3 vector and a uint value.

uint4(uint4)	
Returns a uint4 vector constructed from a uint4 vector.

uint4x2(Boolean)	
Returns a uint4x2 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint4x2(Double)	
Returns a uint4x2 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint4x2(Int32)	
Returns a uint4x2 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint4x2(Single)	
Returns a uint4x2 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint4x2(UInt32)	
Returns a uint4x2 matrix constructed from a single uint value by assigning it to every component.

uint4x2(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint4x2 matrix constructed from from 8 uint values given in row-major order.

uint4x2(bool4x2)	
Return a uint4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.

uint4x2(double4x2)	
Return a uint4x2 matrix constructed from a double4x2 matrix by componentwise conversion.

uint4x2(float4x2)	
Return a uint4x2 matrix constructed from a float4x2 matrix by componentwise conversion.

uint4x2(int4x2)	
Return a uint4x2 matrix constructed from a int4x2 matrix by componentwise conversion.

uint4x2(uint4, uint4)	
Returns a uint4x2 matrix constructed from two uint4 vectors.

uint4x3(Boolean)	
Returns a uint4x3 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint4x3(Double)	
Returns a uint4x3 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint4x3(Int32)	
Returns a uint4x3 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint4x3(Single)	
Returns a uint4x3 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint4x3(UInt32)	
Returns a uint4x3 matrix constructed from a single uint value by assigning it to every component.

uint4x3(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint4x3 matrix constructed from from 12 uint values given in row-major order.

uint4x3(bool4x3)	
Return a uint4x3 matrix constructed from a bool4x3 matrix by componentwise conversion.

uint4x3(double4x3)	
Return a uint4x3 matrix constructed from a double4x3 matrix by componentwise conversion.

uint4x3(float4x3)	
Return a uint4x3 matrix constructed from a float4x3 matrix by componentwise conversion.

uint4x3(int4x3)	
Return a uint4x3 matrix constructed from a int4x3 matrix by componentwise conversion.

uint4x3(uint4, uint4, uint4)	
Returns a uint4x3 matrix constructed from three uint4 vectors.

uint4x4(Boolean)	
Returns a uint4x4 matrix constructed from a single bool value by converting it to uint and assigning it to every component.

uint4x4(Double)	
Returns a uint4x4 matrix constructed from a single double value by converting it to uint and assigning it to every component.

uint4x4(Int32)	
Returns a uint4x4 matrix constructed from a single int value by converting it to uint and assigning it to every component.

uint4x4(Single)	
Returns a uint4x4 matrix constructed from a single float value by converting it to uint and assigning it to every component.

uint4x4(UInt32)	
Returns a uint4x4 matrix constructed from a single uint value by assigning it to every component.

uint4x4(UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32, UInt32)	
Returns a uint4x4 matrix constructed from from 16 uint values given in row-major order.

uint4x4(bool4x4)	
Return a uint4x4 matrix constructed from a bool4x4 matrix by componentwise conversion.

uint4x4(double4x4)	
Return a uint4x4 matrix constructed from a double4x4 matrix by componentwise conversion.

uint4x4(float4x4)	
Return a uint4x4 matrix constructed from a float4x4 matrix by componentwise conversion.

uint4x4(int4x4)	
Return a uint4x4 matrix constructed from a int4x4 matrix by componentwise conversion.

uint4x4(uint4, uint4, uint4, uint4)	
Returns a uint4x4 matrix constructed from four uint4 vectors.

unitexp(quaternion)	
Returns the natural exponent of a quaternion. Assumes w is zero.

unitlog(quaternion)	
Returns the natural logarithm of a unit length quaternion.

unlerp(Double, Double, Double)	
Returns the result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(Single, Single, Single)	
Returns the result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(double2, double2, double2)	
Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(double3, double3, double3)	
Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(double4, double4, double4)	
Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(float2, float2, float2)	
Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(float3, float3, float3)	
Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

unlerp(float4, float4, float4)	
Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).

up()	
Unity's up axis (0, 1, 0).