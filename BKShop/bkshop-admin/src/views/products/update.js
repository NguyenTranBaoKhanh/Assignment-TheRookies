import React, { useEffect, useState } from "react";

import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import { Row, Col } from "react-bootstrap";
import { useForm } from "react-hook-form";
import { useNavigate, useParams } from "react-router-dom";

import productApi from "~/api/productApi";
import brandApi from "~/api/brandApi";
import categoryApi from "~/api/categoryApi";
import imageApi from "~/api/imageApi";

function Update() {
  let navi = useNavigate();
  var { id } = useParams();
  const [categories, setcategories] = useState([]);
  const [brands, setbrands] = useState([]);
  const [product, setproduct] = useState([]);
  const [category, setcategory] = useState([]);
  const [brand, setbrand] = useState([]);
  const {
    register,
    handleSubmit,
    watch,
    formState: { error },
  } = useForm();

  useEffect(() => {
    listCategory();
    listBrand();
    Get();
    GetCategoryById();
    GetBrandById();
  }, []);

  const Get = async () => {
    try {
      const response = await productApi.getByIdAsync(id);
      // console.log(response);
      setproduct(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };

  const GetCategoryById = async () => {
    try {
      const pro = await productApi.getByIdAsync(id);
      const response = await categoryApi.getByIdAsync(pro.categoryId);
      // console.log(response);
      setcategory(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };

  const GetBrandById = async () => {
    try {
      const pro = await productApi.getByIdAsync(id);
      const response = await brandApi.getByIdAsync(pro.brandId);
      // console.log(response);
      setbrand(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };

  const listCategory = async () => {
    try {
      const response = await categoryApi.getAllAsync();
      setcategories(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };
  const listBrand = async () => {
    try {
      const response = await brandApi.getAllAsync();
      // console.log(response);
      setbrand(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };
  const Update = async (content) => {
    try {
      content.Id = id;
      if (content.Name == "") content.Name = product.name;
      if (content.CategoryId == "") content.CategoryId = product.categoryId;
      if (content.BrandId == "") content.BrandId = product.brandId;
      if (content.Capacity == "") content.Capacity = product.capacity;
      if (content.Color == "") content.Color = product.color;
      if (content.Stock == "") content.Stock = product.stock;
      if (content.Price == "") content.Price = product.price;
      if (content.Stock == "") content.Stock = product.stock;
      if (content.Group == "") content.Group = product.group;
      if (content.Description == "") content.Description = product.description;
      let formData = new FormData();
      formData.append("files", content.Image[0]);

      if (content.Image.length == 0) {
        content.Image = product.image.slice(30);
      } else {
        const del = await imageApi.deleteImage(product.image.slice(30));
        content.Image = content.Image[0].name;
      }

      const cre = await imageApi.createImage(formData);
      const response = await productApi.updateAsync(content);
      if (response !== undefined) {
        alert("Cập nhật thành công");
        navi(-1);
      } else {
        alert("Cập nhật thất bại");
      }
    } catch (error) {
      console.log("Faile to create category list: ", error);
    }
  };

  return (
    <div className="p-5">
      <h1>Cập nhật sản phẩm</h1>
      <Form onSubmit={handleSubmit(Update)}>
        <Form.Group className="mb-3" controlId="formBasicEmail">
          <Form.Label>Tên</Form.Label>
          <Form.Control
            type="Text"
            placeholder="Tên"
            defaultValue={product.name}
            {...register("Name")}
          />
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
                <option selected>{category.name}</option>
                {categories.map((item, key) => (
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
                <option selected>{brand.name}</option>
                {brands.map((item, key) => (
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
                defaultValue={product.capacity}
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
                defaultValue={product.color}
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
                defaultValue={product.stock}
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
                defaultValue={product.price}
                {...register("Price")}
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group
              className="position-relative mb-3"
              controlId="formBasicPassword"
            >
              <Form.Label>Hình</Form.Label>
              <Form.Control
                type="File"
                placeholder="Hình"
                defaultValue={product.image}
                {...register("Image")}
              />
            </Form.Group>
          </Col>
          <Col md={4}>
            <Form.Group
              className="position-relative mb-3"
              controlId="formBasicPassword"
            >
              <Form.Label>Nhóm</Form.Label>
              <Form.Control
                type="text"
                placeholder="Nhóm"
                defaultValue={product.group}
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
            defaultValue={product.description}
            {...register("Description")}
          />
        </Form.Group>
        <Button type="submit">Cập nhật</Button>
      </Form>
    </div>
  );
}

export default Update;
