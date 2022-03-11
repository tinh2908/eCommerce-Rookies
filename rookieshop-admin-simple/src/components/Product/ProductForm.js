import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useHistory } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../shared-components/FormInputs/TextField';
import SelectField from '../../shared-components/FormInputs/SelectField';
import { PRODUCT } from '../../Constants/pages';
import { NormalProductType } from "../../Constants/Product/ProductConstants";
import { ProductCategoryOptions, ProductTypeOptions } from "../../Constants/selectOptions";
import FileUpload from '../../shared-components/FormInputs/FileUpload';
import { createProductRequest, UpdateProductRequest } from "./services/request";

const initialFormValues = {
    name: '',
    type: NormalProductType,
    imageFile: undefined
};

const validationSchema = Yup.object().shape({
    name: Yup.string().required('Required'),
    type: Yup.string().required('Required')
});

const ProductFormContainer = ({ initialProductForm = {
    ...initialFormValues
} }) => {
    const [loading, setLoading] = useState(false);

    const isUpdate = initialProductForm.id ? true : false;

    const history = useHistory();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Product ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                history.push(PRODUCT);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateProductAsync = async (form) => {
        console.log('update Product async');
        let data = await UpdateProductRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
            handleResult(true, data.type);
            handleResult(true, data.price);
            handleResult(true, data.categoryid);
        }
    }

    const createProductAsync = async (form) => {  
        console.log('create Product async');
        let data = await createProductRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
            handleResult(true, data.type);
            handleResult(true, data.price);
            handleResult(true, data.categoryid);
        }
    }

    return (
        <Formik
            initialValues={initialProductForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateProductAsync({ formValues: values });
                    }
                    else {
                        createProductAsync({ formValues: values });
                    }

                    setLoading(false);
                }, 1000);
            }}
        >
            {(actions) => (
                <Form className='intro-y col-lg-6 col-12'>
                    <TextField 
                        name="name" 
                        label="Name" 
                        placeholder="Input Product name" 
                        isrequired 
                        disabled={isUpdate ? true : false} />
                    <SelectField 
                        name="type" 
                        label="Type" 
                        options={ProductTypeOptions} 
                        isrequired />
                    <TextField 
                        name="price" 
                        label="Price"
                        />
                    <TextField 
                        name="description" 
                        label="Description"
                        />    
                    <SelectField 
                        name="categoryid" 
                        label="Category"
                        options={ProductCategoryOptions} 
                        isrequired />
                    <div className="d-flex">
                        <div className="ml-auto">
                            <button className="btn btn-danger"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>

                            <Link to={PRODUCT} className="btn btn-outline-secondary ml-2">
                                Cancel
                            </Link>
                        </div>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default ProductFormContainer;
