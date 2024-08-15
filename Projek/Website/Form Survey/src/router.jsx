import { createBrowserRouter, Navigate } from 'react-router-dom'
import Dashboard from './views/Dashboard.jsx'
import Surveys from './views/Surveys.jsx'
import Signup from './views/Signup.jsx'
import Login from './views/Login.jsx'
import Team from './views/Team.jsx'
import GuestLayout from './components/GuestLayout'
import DefaultLayout from './components/DefaultLayout';
import SurveyView from './views/SurveyView';

const router = createBrowserRouter([

  {
    path: "/",
    element: <DefaultLayout />,
    children: [
      {
        path: '/dashboard',
        element: <Navigate to="/" />
      },
      {
        path: '/',
        element: <Dashboard />
      },
      {
        path: '/surveys',
        element: <Surveys />
      },
      {
        path: '/surveys/create',
        element: <SurveyView />
      },
      {
        path: '/team',
        element: <Team />
      },
    ]
  },
  {
    path: '/',
    element: <GuestLayout />,
    children: [
      {
        path: '/login',
        element: <Login />
      },
      {
        path: '/signup',
        element: <Signup />
      },
    ]
  }
]);

export default router;