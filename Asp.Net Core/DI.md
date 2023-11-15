# Remove some services out from DI
```
var descriptor = services.SingleOrDefault(
    d => d.ServiceType ==
        typeof(xxxx) && d.ImplementationType == typeof(xxx));
services.Remove(descriptor);

it may be throw out some exception because of SingleOrDefault, multiple registers for the some type.

services.AddSingleton<xxx, xxx>();
```