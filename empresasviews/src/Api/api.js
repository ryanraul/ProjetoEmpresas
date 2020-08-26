import axios from 'axios'

const api = axios.create({
    baseURL: 'https://localhost:44363/v1/empresas'
});

export default api;