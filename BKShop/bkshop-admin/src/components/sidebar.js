import React from "react";
import {
  CDBSidebar,
  CDBSidebarContent,
  CDBSidebarFooter,
  CDBSidebarHeader,
  CDBSidebarMenu,
  CDBSidebarMenuItem,
} from "cdbreact";
import { NavLink } from "react-router-dom";

function Sidebar() {
  return (
    <div
      className={`app`}
      style={{ display: "flex", height: "100%", overflow: "scroll initial" }}
    >
      <CDBSidebar textColor="#fff" backgroundColor="#333">
        <CDBSidebarHeader prefix={<i className="fa fa-bars fa-large"></i>}>
          <a
            href="/"
            className="text-decoration-none"
            style={{ color: "inherit" }}
          >
            Contrast
          </a>
        </CDBSidebarHeader>

        <CDBSidebarContent className="sidebar-content">
          <CDBSidebarMenu>
            <NavLink exact to="/" activeClassName="activeClicked">
              <CDBSidebarMenuItem icon="columns">dashboard</CDBSidebarMenuItem>
            </NavLink>
            <NavLink exact to="/product" activeClassName="activeClicked">
              <CDBSidebarMenuItem icon="table">Sản phẩm</CDBSidebarMenuItem>
            </NavLink>
            <NavLink exact to="/category" activeClassName="activeClicked">
              <CDBSidebarMenuItem icon="user">Loại</CDBSidebarMenuItem>
            </NavLink>
            <NavLink exact to="/brand" activeClassName="activeClicked">
              <CDBSidebarMenuItem icon="shopping-bag">Hãng</CDBSidebarMenuItem>
            </NavLink>
            <NavLink exact to="/user" activeClassName="activeClicked">
              <CDBSidebarMenuItem icon="shopping-bag">Người dùng</CDBSidebarMenuItem>
            </NavLink>
            <NavLink
              to="/hero404"
              target="_blank"
              activeClassName="activeClicked"
            >
              <CDBSidebarMenuItem icon="exclamation-circle">
                404 page
              </CDBSidebarMenuItem>
            </NavLink>
          </CDBSidebarMenu>
          {/* <CDBSidebarMenu></CDBSidebarMenu> */}
        </CDBSidebarContent>

        <CDBSidebarFooter style={{ textAlign: "center" }}>
          <div
            className="sidebar-btn-wrapper"
            style={{
              padding: "20px 5px",
            }}
          >
            Sidebar Footer
          </div>
        </CDBSidebarFooter>
      </CDBSidebar>
    </div>
  );
}

export default Sidebar;
