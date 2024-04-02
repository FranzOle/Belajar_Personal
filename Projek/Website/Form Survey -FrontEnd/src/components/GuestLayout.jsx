import { Navigate, Outlet } from "react-router-dom";
import { useStateContext } from "../contexts/ContextProvider";


export default function GuestLayout() {
  const {userToken} = useStateContext();

  if(userToken) {
    return <Navigate to="/" />
  }

  return (
    <div className="flex min-h-full items-center justify-center py-12 px-4 sm:px-6 lg:px-8">
      <div className="max-w-md w-full bg-white shadow-2xl rounded-lg p-8 space-y-8">
        <div className="text-center">
          <img
            className="mx-auto h-12 w-auto"
            src="https://i.ibb.co/h73k9n6/k42.png"
            alt="Your Company"
          />
        </div>
        <Outlet />
      </div>
    </div>
  );
}
