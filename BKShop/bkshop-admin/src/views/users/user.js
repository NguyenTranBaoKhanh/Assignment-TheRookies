import { useState, useEffect } from "react";

import { Link } from "react-router-dom";
import { Table } from "reactstrap";

import Button from "react-bootstrap/Button";

import userApi from "~/api/userApi";

function User() {
  const [users, setusers] = useState([]);

  const UserList = async () => {
    try {
      const response = await userApi.getAllAsync();
      // console.log(response);
      setusers(response);
    } catch (error) {
      console.log("Faile to fetch product list: ", error);
    }
  };
  useEffect(() => {
    UserList();
  }, []);
  return (
    <>
      <div style={{ height: "100%" }}>
        <div
          style={{
            padding: "20px 5%",
            height: "calc(100% - 64px)",
            overflowY: "scroll",
          }}
        >
          <div
            style={{
              display: "",
              gridTemplateColumns: "repeat(1, minmax(200px, 700px))",
            }}
          >
            <div className="mt-5">
              <h4 className="font-weight-bold mb-3">Người dùng</h4>
              
              <Table hover responsive bordered>
                <thead color="dark">
                  <tr className="text-center">
                    <th>#</th>
                    <th>Id</th>
                    <th>Tên</th>
                    <th>Địa chỉ</th>
                    <th>Điện thoại</th>
                    <th>Email</th>
                    <th>Thao tác</th>
                  </tr>
                </thead>
                <tbody>
                  {users.map((item, key) => (
                    <tr key={key}>
                      <td>{key + 1}</td>
                      <td>{item.id}</td>
                      <td>{item.name}</td>
                      <td>{item.address}</td>
                      <td>{item.phone}</td>
                      <td>{item.email}</td>
                      <td>
                        <div className="">
                          <Link to="">
                            <Button className="m-2" variant="warning">
                              Sửa
                            </Button>
                          </Link>
                          <Button
                            onClick={() => {
                              var c = window.confirm(
                                ` Bạn muốn xóa ${item.name} không ? `
                              );
                              // if (c) Delete(item.id);
                            }}
                            // onClick={() => {
                            //   handleShow();
                            //   setId(item.id);
                            // }}
                            variant="danger"
                          >
                            Xóa
                          </Button>
                        </div>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </Table>
            </div>
          </div>
          <footer className="mx-auto my-3 text-center">
            <small>&copy; BKShop, 2020. All rights reserved.</small>
          </footer>
        </div>
      </div>
    </>
  );
}

export default User;
