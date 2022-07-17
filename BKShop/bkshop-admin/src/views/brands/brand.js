import React, { useState, useEffect } from "react";
import Button from "react-bootstrap/Button";
import { Link } from "react-router-dom";
import { Table } from "reactstrap";

import brandApi from "~/api/brandApi";

function Brand() {
  const [brands, setBrand] = useState([]);
  const fetchBrandList = async () => {
    try {
      const response = await brandApi.getAllAsync();
      // console.log(response);
      setBrand(response);
    } catch (error) {
      console.log("Faile to fetch brand list: ", error);
    }
  };

  const Delete = async (id) => {
    try {
      const response = await brandApi.deleteAsync(id);
      console.log(response);
      fetchBrandList();
    } catch (error) {
      console.log("Faile to delete brand: ", error);
    }
  };
  useEffect(() => {
    fetchBrandList();
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
              <h4 className="font-weight-bold mb-3">Hãng</h4>
              <Link to="/createBrand">
                <Button color="success" variant="success" className="mb-2">
                  Thêm
                </Button>
              </Link>
              <Table hover responsive bordered>
                <thead color="dark">
                  <tr className="text-center">
                    <th>#</th>
                    <th>Tên</th>
                    <th>Thao tác</th>
                  </tr>
                </thead>
                <tbody>
                  {brands.map((item, key) => (
                    <tr key={key}>
                      <td className="text-center">{key + 1}</td>
                      <td>{item.name}</td>

                      <td>
                        <div className="text-center">
                          <Link to={`/updateBrand/${item.id}`}>
                            <Button className="m-3" variant="warning">
                              Sửa
                            </Button>
                          </Link>
                          <Button
                            onClick={() => {
                              var c = window.confirm(
                                ` Bạn muốn xóa ${item.name} không ? `
                              );
                              if (c) Delete(item.id);
                            }}
                            // onClick={handleShow}
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
export default Brand;
