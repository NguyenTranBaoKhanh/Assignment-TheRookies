import axiosClient from "~/api/axiosClient";

const categoryApi = {
  getAllAsync: (params) => {
    const url = "/category";
    return axiosClient.get(url, { params });
  },
  getByIdAsync: (id) => {
    const url = `/category/${id}`;
    return axiosClient.get(url);
  },
  createAsync: (params) => {
    const url = "/category";
    return axiosClient.post(url, params);
  },
  deleteAsync: async (id) => {
    const url = `/category/${id}`;
    return await axiosClient.delete(url);
  },
  updateAsync: (params) => {
    const url = "/category";
    return axiosClient.put(url, params);
  },
};

export default categoryApi;
