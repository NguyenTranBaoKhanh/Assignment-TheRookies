import { Col } from "react-bootstrap";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import { useForm } from "react-hook-form";
import { useNavigate } from "react-router-dom";

import categoryApi from "~/api/categoryApi";


function CreateCategory() {
  let navi = useNavigate();
  const {
    register,
    handleSubmit,
    watch,
    formState: { error },
  } = useForm();

  const Add = async (content) => {
    try {
      const response = await categoryApi.createAsync(content);
      if(response != undefined) {

        alert("Thêm thành công");
        navi(-1);
      }else{
        alert("Thêm thất bại");
      }
      console.log(content);
    } catch (error) {
      console.log("Faile to create category: ", error);
    }
  };

  return (
    <div className="p-5">
      <h1>Thêm loại sản phẩm</h1>
      <Form  onSubmit={handleSubmit(Add)}>
        <Form.Group as={Col} md ="6" className="mb-3" controlId="formBasicEmail">
          <Form.Label>Tên</Form.Label>
          <Form.Control type="Text" placeholder="Tên" {...register("name")} />
        </Form.Group>
        <Button type="submit">Thêm</Button>
      </Form>
    </div>
  );
}

export default CreateCategory;
