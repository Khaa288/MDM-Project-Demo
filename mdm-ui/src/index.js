import React from 'react';
import ReactDOM from 'react-dom/client';
import Login from './pages/Login';
import {
    createBrowserRouter,
    RouterProvider
} from "react-router-dom";
import Home from './pages/Home';

const router = createBrowserRouter([
    {
        path: "/",
        element: <Login />,
    },

    {
        path: "/home",
        element: <Home />,
    },
]);

ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <RouterProvider router={router} />
    </React.StrictMode>,
)
