﻿using PicView.PicGallery;

namespace PicView.Views.UserControls.Gallery;

/// <summary>
/// Interaction logic for PicGallery.xaml
/// </summary>
public partial class PicGallery
{
    public PicGallery()
    {
        InitializeComponent();

        Loaded += GalleryLoad.PicGallery_Loaded;
    }
}