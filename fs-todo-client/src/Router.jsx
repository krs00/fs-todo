import { createBrowserRouter, RouterProvider } from "react-router-dom";
import App from "./App";

// Page Imports
import ErrorPage from "./views/ErrorPage.jsx";

import AddPage from "./views/AddPage.jsx";
import ListPage from "./views/ListPage.jsx";
import EditPage from "./views/EditPage.jsx";
import DeletePage from "./views/DeletePage.jsx"; 

const Router = () => {
    const router = createBrowserRouter([
        {
            path: "/",
            element: <App />,
            errorElement: <ErrorPage />,
        },
        {
            path: "add-page",
            element: <AddPage />,
        },
        {
            path: "delete-page",
            element: <DeletePage />,
        },
        {
            path: "edit-page",
            element: <EditPage />,
        },
        {
            path: "list-page",
            element: <ListPage />,
        }, 
    ]);

    return <RouterProvider router={router} />;
};

export default Router;