import logo from "./logo.svg";
import "./App.css";
import React from "react";
import Header from "./components/Header";
import Description from "./components/Description";
import ReactDOM from "react-dom";
import Button from "@material-ui/core/Button";
// uses material-ui.com

function App() {
  return (
    <div>
      <Header></Header>
      <Description></Description>
    </div>
    // <div className='App'>
    //   <Button variant='contained' color='primary'>
    //     Hello World
    //   </Button>
    // </div>
  );
}

export default App;
