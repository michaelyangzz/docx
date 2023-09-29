# Array and object destructing

```
//object
const o = {
    name : 'said',
    age: 69
}

const {name, age} = o;
console.log(name);
console.log(age);

//array
const demo-array = ['a','b','c'];
const [value1, value2, value3] = demo-array
```
# Rest and spread
```
const demo-array = ['a','b','c','d','e','f'];
const [value1, value2, value3, ...rest] = demo-array.

const new-array = ['1','2', ...demo-array]
```
# Promise Object

```
const myPromise = new Promise((resolve, reject)=>{
    var results = //long time executions

    if(success)
    {
        resolve(result);
    }
    else
    {
        reject(error);
    }
});
```