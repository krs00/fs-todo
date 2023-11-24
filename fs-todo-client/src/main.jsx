import React from "react";
import ReactDOM from "react-dom/client";
import { createBrowserRouter, RouterProvider } from "react-router-dom";

import App from './App.jsx'

import TestPage from './views/TestPage.jsx'
import MoreTesting from "./views/MoreTesting.jsx";

import './index.css'
import DefaultProfile from "./components/DefaultProfile.jsx";

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
  },
  {
    path: "testpage", 
    element: <TestPage />,
    children: [
      { index: true, element: <DefaultProfile /> },
      { path: "moretesting", element: <MoreTesting /> }
    ]
  },
]);

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
