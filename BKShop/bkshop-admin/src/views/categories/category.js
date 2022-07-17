import { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import { Link, useNavigate } from "react-router-dom";
import { Table } from "reactstrap";
import Modal from "react-bootstrap/Modal";

import categoryApi from "~/api/categoryApi";

function Category() {
  const [categoryList, setcategoryList] = useState([]);

  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);
  var refesh = new useNavigate();
  const [id, setid] = useState();
  const setId = (newId) => {
    setid(newId)
    console.log(id)
  };
  const fetchCategoryList = async () => {
    try {
      const response = await categoryApi.getAllAsync();
      // console.log(response);
      setcategoryList(response);
    } catch (error) {
      console.log("Faile to fetch category list: ", error);
    }
  };

  const Delete = async () => {
    try {
      const response = await categoryApi.deleteAsync(id);
      // console.log(id);
      fetchCategoryList();
    } catch (error) {
      console.log("Faile to delete catrgory list: ", error);
    }
  };

  useEffect(() => {
    fetchCategoryList();
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
              <h4 className="font-weight-bold mb-3">Loại sản phẩm</h4>
              <Link to="/createCategory">
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
                  {categoryList.map((item, key) => (
                    <tr key={key}>
                      <td className="text-center">{key + 1}</td>
                      <td>{item.name}</td>

                      <td>
                        <div className="text-center">
                          <Link to={`/updateCategory/${item.id}`}>
                            <Button className="m-3" variant="warning">
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
                    <Modal.Body>Bạn có muốn xaos không ?</Modal.Body>
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
export default Category;
