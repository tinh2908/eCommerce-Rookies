import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useHistory } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../shared-components/FormInputs/TextField';
import { CATEGORY } from '../../Constants/pages';
import { createCategoryRequest, UpdateCategoryRequest } from "./services/request";

const initialFormValues = {
    name: '',
};

const validationSchema = Yup.object().shape({
    name: Yup.string().required('Required'),
    type: Yup.string().required('Required')
});

const CategoryFormContainer = ({ initialCategoryForm = {
    ...initialFormValues
} }) => {
    const [loading, setLoading] = useState(false);

    const isUpdate = initialCategoryForm.id ? true : false;

    const history = useHistory();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Category ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                history.push(CATEGORY);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateCategoryAsync = async (form) => {
        console.log('update Category async');
        let data = await UpdateCategoryRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    const createCategoryAsync = async (form) => {  
        console.log('create Category async');
        let data = await createCategoryRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    return (
        <Formik
            initialValues={initialCategoryForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateCategoryAsync({ formValues: values });
                    }
                    else {
                        createCategoryAsync({ formValues: values});
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
                        placeholder="input Category name" 
                        isrequired/>
                    
                    <div className="d-flex">
                        <div className="ml-auto">
                            <button className="btn btn-danger"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>

                            <Link to={CATEGORY} className="btn btn-outline-secondary ml-2">
                                Cancel
                            </Link>
                        </div>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default CategoryFormContainer;
