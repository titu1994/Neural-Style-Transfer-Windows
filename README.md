# Neural Style Transfer Windows

Windows Form application written in C# to allow easy changing of Neural Style Transfer scripts (Network.py and INetwork.py) 

- Upon first run, it will request the python path. Traverse your directory to locate the python.exe of your choice (Anaconda is tested)

## Benefits
- Automatically executes the script based on the arguments.
- Easy selection of images (Content, Style, Output Prefix)
- Easy parameter selection
- Easily generate argument list, if command line execution is preferred.
- Logs to see older settings of the script

## Parameters
```
--image_size : Allows to set the Gram Matrix size. Default is 400 x 400, since it produces good results fast. 
--num_iter : Number of iterations. Default is 10. Test the output with 10 iterations, and increase to improve results.
--init_image : Can be "content" or "noise". Default is "content", since it reduces reproduction noise.
--pool_type : Pooling type. AveragePooling ("ave") is default, but smoothens the image too much. For sharper images, use MaxPooling ("max").
--preserve_color : Preserves the original color space of the content image, while applying style. Post processing technique on final image.
--min_improvement : Sets the minimum improvement required to continue training. Default is 0.0, indicating no minimum threshold. Advised values are 0.05 or 0.01.

--content_weight : Weightage given to content in relation to style. Default if 0.025
--style_weight : Weightage given to style in relation to content. Default is 1. 
--style_scale : Scales the style_weight. Default is 1. 
--total_variation_weight : Regularization factor. Smaller values tend to produce crisp images, but 0 is not useful. Default = 1E-5

--rescale_image : Rescale image to original dimensions after each iteration. (Bilinear upscaling)
--rescale_method : Rescaling algorithm. Default is bilinear. Options are nearest, bilinear, bicubic and cubic.
--maintain_aspect_ratio : Rescale the image just to the original aspect ratio. Size will be (gram_matrix_size, gram_matrix_size * aspect_ratio). Default is True
--content_layer : Selects the content layer. Paper suggests conv4_2, but better results can be obtained from conv5_2. Default is conv5_2.
--cpu: Works on CPU if True. Default is False.
```

## Requirements
Windows .NET 4.5 and above to run. 

Script requirements : 
- TensorFlow/Theano
- Keras
- CUDA (GPU)
- CUDNN (GPU)
- Scipy + PIL
- Numpy

Tested on Windows 10, Python 3.8, TensorFlow 2.4, CUDA 11.2, CuDNN 8.0.5.
