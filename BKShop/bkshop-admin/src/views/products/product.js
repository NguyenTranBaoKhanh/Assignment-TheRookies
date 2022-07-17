import { Table, ButtonGroup } from "reactstrap";
import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";

import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";

import productApi from "~/api/productApi";
import imageApi from "~/api/imageApi";

function Product() {
  const [productList, setProductList] = useState([]);

  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  const [id, setid] = useState();
  const setId = (newId) => {
    setid(newId);
  };

  useEffect(() => {
    fetchProductList();
  }, []);

  const fetchProductList = async () => {
    try {
      const response = await productApi.getAllAsync();
      // console.log(response);
      setProductList(response);
    } catch (error) {
      console.log("Faile to fetch product list: ", error);
    }
  };
  const fetchProductListPaging = async () => {
    try {
      const params = {
        PageIndex: 1,
        PageSize: 5,
      };
      const response = await productApi.getPagingAsync(params);
      console.log(response.items);
    } catch (error) {
      console.log("Faile to fetch product list: ", error);
    }
  };
  const fetchProductById = async (id) => {
    try {
      const response = await productApi.getByIdAsync(id);
      console.log(response);
    } catch (error) {
      console.log("Faile to fetch product: ", error);
    }
  };

  const Delete = async (id) => {
    try {
      const product = await productApi.getByIdAsync(id);
      const res = await imageApi.deleteImage(product.image.slice(30));
      console.log(product.image.slice(30));
      const response = await productApi.deleteAsync(id);
      console.log(res)
      fetchProductList();
    } catch (error) {
      console.log("Faile to fetch product: ", error);
    }
  };

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
              <h4 className="font-weight-bold mb-3">Sản phẩm</h4>
              <Link to="/createProduct">
                <Button color="success" variant="success" className="mb-2">
                  Thêm
                </Button>
              </Link>
              <Table hover responsive bordered>
                <thead color="dark">
                  <tr className="text-center">
                    <th>#</th>
                    <th>Tên</th>
                    <th>Màu</th>
                    <th>Dung lượng</th>
                    <th>Giá</th>
                    <th>Mô tả</th>
                    <th>Hình</th>
                    <th>Thao tác</th>
                  </tr>
                </thead>
                <tbody>
                  {productList.map((item, key) => (
                    <tr key={key}>
                      <td>{key + 1}</td>
                      <td>{item.name}</td>
                      <td>{item.color}</td>
                      <td>{item.capacity}</td>
                      <td>{item.price}</td>
                      <td>{item.description}</td>
                      <td>
                        <img style={{ width: "10rem" }} src={item.image} />
                      </td>
                      <td>
                        <div className="">
                          <Link to={`/updateProduct/${item.id}`}>
                            <Button className="mb-3" variant="warning">
                              Sửa
                            </Button>
                          </Link>
                          <Button
                            // onClick={() => {
                            //   var c = window.confirm(
                            //     ` Bạn muốn xóa ${item.name} không ? `
                            //   );
                            //   if (c) Delete(item.id);
                            // }}
                            onClick={() => {
                              handleShow();
                              setId(item.id);
                            }}
                            variant="danger"
                          >
                            Xóa
                          </Button>
                        </div>
                      </td>
                    </tr>
                  ))}
                  <Modal show={show} onHide={handleClose}>
                    <Modal.Header>
                      <Modal.Title>Xóa sản phẩm</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>Bạn có muốn xoa không ?</Modal.Body>
                    <Modal.Footer>
                      <Button variant="secondary" onClick={handleClose}>
                        Không
                      </Button>
                      <Button
                        variant="danger"
                        onClick={() => {
                          handleClose();
                          Delete(id);
                        }}
                      >
                        Xóa
                      </Button>
                    </Modal.Footer>
                  </Modal>
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
export default Product;
