import React from "react";
import { Modal, } from "react-bootstrap";

import { 
  NormalProductType,
  NormalProductTypeLabel,
  LuxuryProductType, 
  LuxuryProductTypeLabel 
} from "../../../Constants/Product/ProductConstants";

const Info = ({ product, handleClose }) => {
  const getProductTypeName = (id) => {
    return id == LuxuryProductType ? LuxuryProductTypeLabel : NormalProductTypeLabel;
  }

  return (
    <>
      <Modal
        show={true}
        onHide={handleClose}
        dialogClassName="modal-90w"
      >
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Product Infomation
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <div>
            <div className='row -intro-y'>
              <div className='col-4'>Id:</div>
              <div>{product.id}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Name:</div>
              <div>{product.name}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Description:</div>
              <div>{product.description}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>price:</div>
              <div>{product.price}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Type:</div>
              <div>{getProductTypeName(product.type)}</div>
            </div>
{/* 
            <div className='row -intro-y'>
              <div className='col-4'>Image:</div>
              <div>
                <img src={product.imagePath} className='object-center w-full rounded-md' />
              </div>
            </div> */}

          </div>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;