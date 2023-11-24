import { createBrowserRouter, RouterProvider } from "react-router-dom";
import App from "./App";
import TestPage from './views/TestPage.jsx'


import MoreTesting from "./views/MoreTesting.jsx";
import ErrorPage from "./views/ErrorPage.jsx";

const Router = () => {
    const router = createBrowserRouter([
        {
            path: "/",
            element: <App />,
            errorElement: <ErrorPage />,
        },
        {
            path: "testpage",
            element: <TestPage />,
        },
        {
            path: "/testpage/moretesting",
            element: <MoreTesting />,
        },
    ]);

    return <RouterProvider router={router} />;
};

export default Router;