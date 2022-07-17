import axiosClient from "~/api/axiosClient";

const brandApi = {
  getAllAsync: async (params) => {
    const url = "/brand";
    return await axiosClient.get(url, { params });
  },
  getByIdAsync: async (id) => {
    const url = `/brand/${id}`;
    return await axiosClient.get(url);
  },
  createAsync: async (params) => {
    const url = "/brand";
    return await axiosClient.post(url, params);
  },
  updateAsync: async (params) => {
    const url = "/brand";
    return await axiosClient.put(url, params);
  },
  deleteAsync : async (id) => {
    const url = `/brand/${id}`
    return await axiosClient.delete(url)
  }
};

export default brandApi
