import React from 'react';
import axios from 'axios';
import "./item.scss";
import ReactCrop from 'react-image-crop'
import 'react-image-crop/src/ReactCrop.scss'
import { Button, Form } from 'react-bootstrap';
import "./AddItem.scss";
export default class AddItemPage extends React.Component {
    
    state = {
        src: null,
        resultImg: null,
        Name: "",
        crop: {
          unit: '%',
          width: 30,
          aspect: 290 / 357
        },
        input:{
            Name: "",
            Price: "",
            OnDiscount: false,
            DiscountValue: 0,
            IsInStock: false,
            PreviewImage: null
        }

      };

    constructor() {
        super();
        this.getCroppedImg = this.getCroppedImg.bind(this);   
    }

      onSelectFile = (e) => {
          this.state.crop.unit = '%';
          this.state.crop.width = 30;
          this.state.crop.aspect = 290 / 357;
        if (e.target.files && e.target.files.length > 0) {
          const reader = new FileReader();
          reader.addEventListener('load', () =>
            this.setState({ src: reader.result })
          );
          reader.readAsDataURL(e.target.files[0]);
        }
      };
    
      // If you setState the crop in here you should return false.
      onImageLoaded = (image) => {
        this.imageRef = image;
      };
    
      onCropComplete = (crop) => {
        this.makeClientCrop(crop);
      };
    
      onCropChange = (crop, percentCrop) => {
        // You could also use percentCrop:
        // this.setState({ crop: percentCrop });
        this.setState({ crop });
      };
    
      async makeClientCrop(crop) {
        if (this.imageRef && crop.width && crop.height) {
          const croppedImageUrl = await this.getCroppedImg(
            this.imageRef,
            crop,
            'newFile.jpeg'
          );
          this.setState({ croppedImageUrl });
        }
      }
    
      getCroppedImg(image, crop, fileName) {
        const canvas = document.createElement('canvas');
        const pixelRatio = window.devicePixelRatio;
        const scaleX = image.naturalWidth / image.width;
        const scaleY = image.naturalHeight / image.height;
        const ctx = canvas.getContext('2d');
    
        canvas.width = crop.width * pixelRatio * scaleX;
        canvas.height = crop.height * pixelRatio * scaleY;
    
        ctx.setTransform(pixelRatio, 0, 0, pixelRatio, 0, 0);
        ctx.imageSmoothingQuality = 'high';
    
        ctx.drawImage(
          image,
          crop.x * scaleX,
          crop.y * scaleY,
          crop.width * scaleX,
          crop.height * scaleY,
          0,
          0,
          crop.width * scaleX,
          crop.height * scaleY
        );

        return new Promise((resolve, reject) => {
          canvas.toBlob(
            (blob) => {
              if (!blob) {
                console.error('Canvas is empty');
                return;
              }
                blob.name = fileName;
                window.URL.revokeObjectURL(this.fileUrl);
                this.fileUrl = window.URL.createObjectURL(blob);
                resolve(this.fileUrl);
                const reader = new FileReader();
                reader.readAsDataURL(blob);
                reader.onloadend = () => { 
                    this.setState({ resultImg: reader.result })
                }
            },
            'image/jpeg',
            1
          );
        });
      }
    
      handleSubmit(event){
        event.preventDefault();
        alert(this.state.input.Name );
      }

      handleChange(event){
        this.setState(
            {Name: event.target.value}
        );
      }
      render() {
        const { crop, croppedImageUrl, src } = this.state;
        document.title = "Add item";
        return (
          <div className="container">
            <div>
              <input className="custom-file-input" type="file" accept="image/*" onChange={this.onSelectFile} />
            </div>
            <div className="row">
                <div className="column left">
                {src && (
                <ReactCrop
                    style={{ maxWidth: "50%" }}
                    src={src}
                    crop={crop}
                    ruleOfThirds
                    onImageLoaded={this.onImageLoaded}
                    onComplete={this.onCropComplete}
                    onChange={this.onCropChange}
                />
                )}
                </div>
                <div className="column right">
                    {croppedImageUrl && (<img alt="Crop" style={{ maxHeight: '300px' }} src={croppedImageUrl} />)}
                </div>
            </div>

            <Form onSubmit={this.handleSubmit}>
                <div>
                    <Form.Group className="mb-3" value={this.state.input.Name}>
                        <Form.Label>Name</Form.Label>
                        <Form.Control type="text" placeholder="Enter name" value={this.state.Name} onChange={this.handleChange} />
                    </Form.Group>

                    <Form.Group className="mb-3" >
                        <Form.Label>Price</Form.Label>
                        <Form.Control type="text" placeholder="Price" />
                    </Form.Group>

                    <Form.Group className="mb-3" controlId="formBasicCheckbox">
                        <Form.Check type="checkbox" label="In stock ?" />
                    </Form.Group>
                </div>
                <Button variant="dark" type="submit">Create</Button>
            </Form>
          </div>
        );
      }
    }