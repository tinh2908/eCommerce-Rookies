import { AxiosResponse } from "axios";
import qs from 'qs';

import RequestService from '../../../services/request';
import EndPoints from '../../../Constants/endpoints';

export function createCategoryRequest(categoryForm) {
    const formData = new FormData();

    Object.keys(categoryForm).forEach(key => {
        formData.append(key, categoryForm[key]);
    });

    return RequestService.axios.post(EndPoints.category, formData);
}

export function getCategoryRequest(query) {
    return RequestService.axios.get(EndPoints.category, {
        params: query,
        paramsSerializer: params => qs.stringify(params),
    });
}

export function UpdateCategoryRequest(categoryForm) {
    const formData = new FormData();

    Object.keys(categoryForm).forEach(key => {
        formData.append(key, categoryForm[key]);
    });

    return RequestService.axios.put(EndPoints.categoryID(categoryForm.id ?? - 1), formData);
}

export function DisableCategoryRequest(categoryID) {
    return RequestService.axios.delete(EndPoints.categoryID(categoryID));
}