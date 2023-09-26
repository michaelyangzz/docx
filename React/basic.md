- React Component name must start with a capital letter, while HTML tag must be lowercase.
- JSX use {} to enter javascript scope. out side of {} is normal HTML Dom.
- A Module is just a file, can import/export functions/variable
- A Module only can works on HTTP(s), not locally. If you try to open a web-page locally, via file:// protocol, you’ll find that import/export directives don’t work.
- A Module is a self scope, can not see each other's functions/var.
- Global var please use window.abc
- A module code is evaluated only the first time when imported;
- top-level vars equal to singleton. if you want to execute some codes multiple times, please put in into functions.
- The object import.meta contains the information about the current module.such as import.meta.url.
- relative order of scripts is maintained: scripts that go first in the document, execute first. But module script deferred after regular script, which is a part of DOM.
- rendering list must have a key.
- Notice how onClick={handleClick} has no parentheses at the end!
- Re-rendering a component could not produce any DOM changes. React updates DOM only if the render process produces changes.
- For example, you could have a component that is making an API request every minute (imagine it returns an object with some user data). When the API result comes, you could update some internal component state (calling setState with the API result) that will produce a re-render. But if nothing in the resulting virtual DOM tree changes (because nothing in the user data has changed), nothing in the DOM will be updated.
- React.StrictMode call hooks setState twice to make sure your function pure. 

# Pure
- It minds its own business. It does not change any objects or variables that existed before it was called.
- Same inputs, same output. Given the same inputs, a pure function should always return the same result.