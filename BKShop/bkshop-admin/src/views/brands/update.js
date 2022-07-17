import { useEffect, useState } from "react";
import { Col } from "react-bootstrap";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import { useForm } from "react-hook-form";
import { useNavigate, useParams } from "react-router-dom";

import brandApi from "~/api/brandApi";

function UpdateBrand() {
  let navi = useNavigate();
  var { id } = useParams();

  const [brand, setbrand] = useState([]);
  const {
    register,
    handleSubmit,
    watch,
    formState: { error },
  } = useForm();

  const Get = async () => {
    try {
      const response = await brandApi.getByIdAsync(id);
      // console.log(response);
      setbrand(response);
    } catch (error) {
      console.log("Faile to create catrgory list: ", error);
    }
  };

  const Update = async (content) => {
    try {
      content.Id = id;
      if (content.Name == "") content.Name = brand.name;
      const response = await brandApi.updateAsync(content);
      if (response !== undefined) {
        alert("Cấp nhật thành công");
        navi(-1);
      } else {
        alert("Cập nhật thất bại");
      }
    } catch (error) {
      console.log("Faile to update brand: ", error);
    }
  };

  useEffect(() => {
    Get();
  }, []);

  return (
    <div className="p-5">
      <h1>Cập nhật hãng</h1>
      <Form onSubmit={handleSubmit(Update)}>
        <Form.Group as={Col} md="6" className="mb-3" controlId="formBasicEmail">
          <Form.Label>Tên</Form.Label>
          <Form.Control
            type="Text"
            placeholder="Tên"
            defaultValue={brand.name}
            {...register("Name")}
          />
        </Form.Group>
        <Button type="submit">Cập nhật</Button>
      </Form>
    </div>
  );
}

export default UpdateBrand;
