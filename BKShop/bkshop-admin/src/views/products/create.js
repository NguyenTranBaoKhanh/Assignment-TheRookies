import { useEffect, useState } from "react";
import { Col, Row } from "react-bootstrap";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import { useForm } from "react-hook-form";
import { useNavigate } from "react-router-dom";

import brandApi from "~/api/brandApi";
import categoryApi from "~/api/categoryApi";
import productApi from "~/api/productApi";
import imageApi from "~/api/imageApi";

function Create() {
  let navi = useNavigate();
  const [category, setcategory] = useState([]);
  const [brand, setbrand] = useState([]);
  const {
    register,
    handleSubmit,
    watch,
    formState: { error },
  } = useForm();

  const listBrand = async () => {
    try {
      const response = await brandApi.getAllAsync();
      // console.log(response);
      setbrand(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };

  const listCategory = async () => {
    try {
      const response = await categoryApi.getAllAsync();
      // console.log(response);
      setcategory(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };
  const Add = async (content) => {
    let formData = new FormData();
    formData.append("files", content.Image[0]);
    if (content.Image.length == 0) {
      content.Image = "default.jpg";
    } else {
      content.Image = content.Image[0].name;
    }

    console.log(content);
    const res = await imageApi.createImage(formData);
    const response = await productApi.createAsync(content);
    console.log(response);
    if (response !== undefined) {
      alert("Thêm thành công");
      navi(-1);
    } else {
      alert("Thêm thất bại");
    }
  };

  useEffect(() => {
    listBrand();
    listCategory();
  }, []);

  return (
    <div className="p-5">
      <h1>Tạo sản phẩm</h1>
      <Form onSubmit={handleSubmit(Add)}>
        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Tên</Form.Label>
          <Form.Control type="Text" placeholder="Tên" {...register("Name")} />
        </Form.Group>
        <Row>
          <Col md={6}>
            <Form.Group className="mb-3" controlId="formBasicEmail">
              <Form.Label>Loại</Form.Label>
              <select
                className="form-control"
                aria-label="Default select example"
                {...register("CategoryId")}
              >
                <option>Select one</option>
                {category.map((item, key) => (
                  <option key={key} value={item.id}>
                    {item.name}
                  </option>
                ))}
              </select>
            </Form.Group>
          </Col>
          <Col md={6}>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Hãng</Form.Label>
              <select
                className="form-control"
                aria-label="Default select example"
                {...register("BrandId")}
              >
                <option>Select one</option>
                {brand.map((item, key) => (
                  <option key={key} value={item.id}>
                    {item.name}
                  </option>
                ))}
              </select>
            </Form.Group>
          </Col>
        </Row>
        <Row>
          <Col md={4}>
            <Form.Group className="mb-3" controlId="formBasicEmail">
              <Form.Label>Dung lượng</Form.Label>
              <Form.Control
                type="text"
                placeholder="Dung lượng"
                {...register("Capacity")}
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Màu</Form.Label>
              <Form.Control
                type="text"
                placeholder="Màu"
                {...register("Color")}
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Số lượng</Form.Label>
              <Form.Control
                type="number"
                placeholder="Số lượng"
                {...register("Stock")}
              />
            </Form.Group>
          </Col>
        </Row>
        <Row>
          <Col md={4}>
            <Form.Group className="mb-3" controlId="formBasicEmail">
              <Form.Label>Giá</Form.Label>
              <Form.Control
                type="text"
                placeholder="Giá"
                {...register("Price")}
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group className=" mb-3" controlId="formFile">
              <Form.Label>Hình</Form.Label>
              <Form.Control
                type="File"
                placeholder="Hình"
                {...register("Image")}
              />
            </Form.Group>
          </Col>
          {/* <Col md={3}>
            <Form.Group className=" mb-3" controlId="formFile">
              <Form.Label>Hình</Form.Label>
              <Form.Control
                type="text"
                placeholder="Hình"
                {...register("Image")}
              />
            </Form.Group>
          </Col> */}
          <Col md={4}>
            <Form.Group
              className="position-relative mb-3"
              controlId="formBasicPassword"
            >
              <Form.Label>Nhóm</Form.Label>
              <Form.Control
                type="text"
                placeholder="Nhóm"
                {...register("Group")}
              />
            </Form.Group>
          </Col>
        </Row>
        <Form.Group className=" mb-3" controlId="formBasicPassword">
          <Form.Label>Mô tả</Form.Label>
          <Form.Control
            type="text"
            placeholder="Mô tả"
            {...register("Description")}
          />
        </Form.Group>
        <Button type="submit">Thêm</Button>
      </Form>
    </div>
  );
}

export default Create;
