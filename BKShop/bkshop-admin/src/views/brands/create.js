import { Col } from "react-bootstrap";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import { useForm } from "react-hook-form";
import { useNavigate } from "react-router-dom";

import brandApi from "~/api/brandApi";


function CreateBrand() {
  let navi = useNavigate();
  const {
    register,
    handleSubmit,
    watch,
    formState: { error },
  } = useForm();

  const Add = async (content) => {
    try {
      const response = await brandApi.createAsync(content);
      if (response !== undefined) {
        alert("Thêm thành công");
        navi(-1);
      } else {
        alert("Thêm thất bại");
      }
      console.log(content);
    } catch (error) {
      console.log("Faile to create brand: ", error);
    }
  };

  return (
    <div className="p-5">
      <h1>Thêm hãng</h1>
      <Form  onSubmit={handleSubmit(Add)}>
        <Form.Group as={Col} md ="6" className="mb-3" controlId="formBasicEmail">
          <Form.Label>Tên</Form.Label>
          <Form.Control type="Text" placeholder="Tên" {...register("Name")} />
        </Form.Group>
        <Button type="submit">Thêm</Button>
      </Form>
    </div>
  );
}

export default CreateBrand;
