import axiosFile from "~/api/axiosFile";

const imageApi = {
  createImage: async (params) => {
    const url = "/Image";
    return await axiosFile.post(url,  params );
  },
  deleteImage: async (imageName) => {
    const url = `/image/${imageName}`;
    return await axiosFile.delete(url);
  },
};
 export default imageApi;