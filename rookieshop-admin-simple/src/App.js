import React, { lazy, Suspense, useEffect } from "react";
import logo from "./logo.svg";
import "./App.css";
import HelloElement from "./HelloWorld";
import Home from "./components/Home";
import Navbar from "./components/Navbar";
import Contact from "./components/Contact";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import InLineLoader from "./shared-components/InlineLoader";
import { PRODUCT } from "./Constants/pages";
import { CATEGORY } from "./Constants/pages";

const Product = lazy(() => import('./components/Product'));
const Category = lazy(() => import('./components/Category'));

const SusspenseLoading = ({ children }) => (
  <Suspense fallback={<InLineLoader />}>
    {children}
  </Suspense>
);

class App extends React.Component {
  state = {
    bootcamp: "Rookies",
    homeClass: "",
  };

  updateName() {
    this.setState({
      isShowHelloElement: !this.state.isShowHelloElement,
      bootcamp: "sdfalsfjlsd",
    });
  }

  handleSearchKey(e) {
    console.log(e.target.value);
  }

  /*
  render() {
    return (
      <Router>
        <div className="App">
          <Navbar onSearchKey={(e) => this.handleSearchKey(e)} />

          <Route exact path="/">
            <Home bootcamp={this.state.bootcamp} />
          </Route>
          <Route exact path="/contact">
            <Contact />
          </Route>
          <Route exact path="/hello">
            <HelloElement />
          </Route>
          <Route path="/brand">
            <Brand />
          </Route>
        </div>
      </Router>
    );
  }
  */

  render() {
    return (
      <Router>
        <div className="App">
          <Navbar onSearchKey={(e) => this.handleSearchKey(e)} />

          <SusspenseLoading>
            <Switch>
              <Route exact path="/">
                <Home bootcamp={this.state.bootcamp} />
              </Route>
                <Route exact path="/contact">
              <Contact />
              </Route>
                <Route exact path="/hello">
              <HelloElement />
              </Route>

              <Route path={PRODUCT}>
                <Product />
              </Route>
              <Route path={CATEGORY}>
                <Category />
              </Route>
          </Switch>
         </SusspenseLoading>
        </div>
      </Router>
    );
  }
}

export default App;
