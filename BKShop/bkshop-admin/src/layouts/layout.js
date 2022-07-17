import { Outlet } from "react-router-dom";

import Navbar from "~/components/navbar";
import Sidebar from "~/components/sidebar";

function Layout() {
  return (
    <>
      <div className="d-flex">
        <div>
          <Sidebar />
        </div>
        <div
          style={{
            flex: "1 1 auto",
            display: "flex",
            flexFlow: "column",
            height: "100vh",
            overflowY: "hidden",
          }}
        >
          {/* <Navbar /> */}
          <Outlet />
        </div>
      </div>
    </>
  );
}

export default Layout;
