// import Routes from "~/Routes"
import { BrowserRouter, Route, Routes } from "react-router-dom";
import "~/assets/css/dashboard.css";

import Brand from "~/views/brands/brand";
import Category from "~/views/categories/category";
import Product from "~/views/products/product";
import User from "~/views/users/user";
import Layout from "~/layouts/layout";
import Create from '~/views/products/create';
import Update from '~/views/products/update';
import CreateCategory from "./views/categories/create";
import UpdateCategory from "./views/categories/update";
import CreateBrand from "./views/brands/create";
import UpdateBrand from "./views/brands/update";

import "./App.css";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route path="/category" element={<Category />} />
          <Route path="/brand" element={<Brand />} />
          <Route path="/product" element={<Product />} />
          <Route path="/user" element={<User />} />
          <Route path="/createProduct" element={<Create />} />
          <Route path="/updateProduct/:id" element={<Update />} />
          <Route path="/createCategory" element={<CreateCategory />} />
          <Route path="/updateCategory/:id" element={<UpdateCategory />} />
          <Route path="/createBrand" element={<CreateBrand />} />
          <Route path="/updateBrand/:id" element={<UpdateBrand />} />

        </Route>
      </Routes>
    </BrowserRouter>

    // <div>
    // 	<Routes/>
    // </div>
  );
}

export default App;
