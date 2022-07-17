import axiosClient from "~/api/axiosClient";

const userApi = {
  getAllAsync: async () => {
    const url = "/user";
    return await axiosClient.get(url);
  },
};

export default userApi;
