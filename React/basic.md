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
- Dom updates vs React Components Rerender same as above item.
- Array.slice() to clone the array. 
- Extend the array to a new one, [...oldArray, newItem], same as object.
- immutability is important to learn
- Although re-rendering child components is not by itself noticeable to the user (you shouldn’t actively try to avoid it!)
- For the state, the less the better.
- key is a special and reserved property in React. When an element is created, React extracts the key property and stores the key directly on the returned element. Even though key may look like it is passed as props, React automatically uses key to decide which components to update.
- you must never nest their definitions of components.
- preserved props, children/className/width/height/key and so on.
- remove an element from dom, just return null from your component.
- Don’t put numbers on the left side of &&.
- === more strict than ==, check type as well as value, but == only check value.
- e.preventDefault() to prevent default browser built-in event handler.
- e.stopPropagation() to stop events from flowing up the tree.
- capture events even stopPropagation.
   ```
   <div onClickCapture={() => { /* this runs first */ }}>
    <button onClick={e => e.stopPropagation()} />
    <button onClick={e => e.stopPropagation()} />
   </div>
   ```
- array.filter create a new array, but array.find don't.
- React Hooks: Not Magic, Just Arrays. so, hook order is very important.
- React Three Steps Trigger->Render>Commit.
- Why say state as a snapshot, even the props and build-in props.
- React will not render multiple times when setState multiple times in the same scope, render only once in one handler scope.
- async await Promise
- import { useImmer } from 'use-immer' for object/array state updating.
- Remember that it’s the position in the UI tree—not in the JSX markup—that matters to React!
- key is the position.
- Same component at the same position preserves state 
- Different components at the same position reset state 
- React destroys state when it removes a component from the tree.
- always declare component functions at the top level, and don’t nest their definitions.
- Remember that keys are not globally unique. They only specify the position within the parent.
- always wrapper the context.provider with children prop!!!!!!otherwise all child components will re-render even no useContext.
- Map vs Object.
- Prevent race condition when fetch data
  ```
  useEffect(() => {
  let ignore = false;

  async function startFetching() {
    const json = await fetchTodos(userId);
    if (!ignore) {
      setTodos(json);
    }
  }

  startFetching();

  return () => {
    ignore = true;
  };
  }, [userId]);
  ```
- Component lifecycle Mount->Update->UnMount.
- A useState and A useEffect together is a complete c/s data unit.

# Pure
- It minds its own business. It does not change any objects or variables that existed before it was called.
- Same inputs, same output. Given the same inputs, a pure function should always return the same result.
- so any functions that has return values should be pure in React. not only for function Component, such as set state function, useMemo function.
- reactive values include props/state/variables in components based on props/states. 
- reactive logic includes function components, effects, but not event handlers.
- try to run effects as fewer as possible.