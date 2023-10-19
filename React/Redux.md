# Development tools
- [React Developer tool](https://chrome.google.com/webstore/detail/react-developer-tools/fmkadmapgofadopljbjfkapdkoienihi?hl=en)
- [Redux Dev tool](https://chrome.google.com/webstore/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd?hl=en)

# Normal Steps
- state structure
- define actions
- define reducers - pure functions

# Overview
![](pics/ReduxDataFlowDiagram001.gif)
![](pics/ReduxAsyncDataFlowDiagram002.gif)

# some info
- useSelector will re-calculate ever time the root state changes, but if the result of useSelector is not changed, it will not cause the React Component re-render.  so it should be a place we consider the performance. 
- dispatch the thunk function , then convert it onto plain object action in middleware.
- how to do shallow equal in javascript?
