# && vs & || vs |

Double operator is a “short -circuit” operator.  
A || B || C, if A is true, B and C will not be checked. Faster performance.  
A && B && C,  if A is false, B and C will not be checked.

# ModuleInitializerAttribute

put this attribute onto static method, which the compile will call when module initializer. [refer here for details](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.moduleinitializerattribute?view=net-7.0)
