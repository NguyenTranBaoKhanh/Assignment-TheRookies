import axiosClient from "~/api/axiosClient";
import axiosFile from "~/api/axiosFile";

const productApi = {
  getAllAsync: (params) => {
    const url = "/product";
    return axiosClient.get(url, { params });
  },
  getPagingAsync: (params) => {
    const url = "/product/Paging";
    return axiosClient.get(url, { params });
  },
  getByIdAsync: (id) => {
    const url = `/product/${id}`;
    return axiosClient.get(url);
  },
  updateAsync: (params) => {
    const url = "/product";
    return axiosFile.put(url, params);
  },
  createAsync: async (params) => {
    // axiosClient.interceptors.request.use(async (config) => {
    //   var newConfig = {};
    //   newConfig = {
    //     ...config,
    //     headers: {
    //       // "Content-Type": "application/json",
    //       "Content-Type": "multipart/form-data",
    //     },
    //   };
    //   return newConfig;
    // });
    const url = "/product";
    return await axiosFile.post(url, params);
  },
  deleteAsync: async (id) => {
    const url = `/product/${id}`;
    return await axiosClient.delete(url);
  },
};
export default productApi;
