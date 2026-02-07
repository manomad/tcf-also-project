import axios from "axios";

export const ApiHelper = {
    baseUrl: process.env.LICENSE_MANAGER_API_URL || 'http://localhost:5000/api',
};

export const fetcher = (url: string) => axios.get(url).then(res => res.data);