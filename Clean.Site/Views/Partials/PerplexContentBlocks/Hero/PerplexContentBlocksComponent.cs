using Perplex.ContentBlocks.Definitions;
using Umbraco.Cms.Core.Composing;

namespace Clean.Site.Views.Partials.blocklist.component
{
    public class PerplexContentBlocksComponent : IComponent
    {
        private readonly IContentBlockDefinitionRepository _definitions;
        public PerplexContentBlocksComponent(IContentBlockDefinitionRepository definitions)
        {
            _definitions = definitions;
        }
        public void Initialize()
        {
            var heroBlock = new ContentBlockDefinition
            {
                Name = "Hero Content Block", //name of the block
                Id = Guid.Parse("158add94-3daf-452a-9170-ddefc21c2f0b"),//unique id, create your own guid
                DataTypeKey = Guid.Parse("833dfef2-ea06-49e8-8b65-7202e5d3e99e"), //datatype key for the nested content data type that was created
                PreviewImage = "/assets/img/post-bg.jpg", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
               {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    ///_demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
               {
                    new ContentBlockLayout
                    {
                        Id =Guid.Parse("5c592713-4931-413d-b593-1f9860c70322"), //unique id, create your own guid
                        Name = "Layout 1",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/about-bg.jpg", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Layout1.cshtml" //view for website rendering
                    },
                    new ContentBlockLayout
                    {
                        Id = Guid.NewGuid(),
                        Name = "Layout 2",
                        Description = "Centre Aligned Text",
                        PreviewImage = "/assets/img/home-bg.jpg",
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Layout2.cshtml"
                    },
               }
            };

            var Block1 = new ContentBlockDefinition
            {
                Name = "Block1", //name of the block
                Id = Guid.NewGuid(),//unique id, create your own guid
                DataTypeKey = Guid.Parse("353e51cf-65c0-494a-a650-78627fa2a974"), //datatype key for the nested content data type that was created
                PreviewImage = "/assets/img/post-bg.jpg", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
               {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    ///_demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
               {
                    new ContentBlockLayout
                    {
                        Id =Guid.NewGuid(), //unique id, create your own guid
                        Name = "Block 1",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/about-bg.jpg", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Block1.cshtml" //view for website rendering
                    },
               }
            };
            var Block2 = new ContentBlockDefinition
            {
                Name = "Block2", //name of the block
                Id = Guid.NewGuid(),//unique id, create your own guid
                DataTypeKey = Guid.Parse("d7d91dc6-0888-4215-b282-b70373a3e947"), //datatype key for the nested content data type that was created
                PreviewImage = "/assets/img/post-bg.jpg", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block2", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
               {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    ///_demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
               {
                    new ContentBlockLayout
                    {
                        Id =Guid.NewGuid(), //unique id, create your own guid
                        Name = "Block 2",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/about-bg.jpg", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Block2.cshtml" //view for website rendering
                    },
               }
            };
            var Block3 = new ContentBlockDefinition
            {
                Name = "Block3", //name of the block
                Id = Guid.NewGuid(),//unique id, create your own guid
                DataTypeKey = Guid.Parse("53d98641-ff2a-4239-95b2-fa3e3bdaeca7"), //datatype key for the nested content data type that was created
                PreviewImage = "/assets/img/post-bg.jpg", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block3", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
               {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    ///_demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
               {
                    new ContentBlockLayout
                    {
                        Id =Guid.NewGuid(), //unique id, create your own guid
                        Name = "Block 3",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/about-bg.jpg", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Block3.cshtml" //view for website rendering
                    },
               }
            };
            var Block4 = new ContentBlockDefinition
            {
                Name = "Block4", //name of the block
                Id = Guid.NewGuid(),//unique id, create your own guid
                DataTypeKey = Guid.Parse("199712be-eabb-405e-a027-ac770ed93f9a"), //datatype key for the nested content data type that was created
                PreviewImage = "/assets/img/post-bg.jpg", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block4", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
               {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    ///_demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
               {
                    new ContentBlockLayout
                    {
                        Id =Guid.NewGuid(), //unique id, create your own guid
                        Name = "Block 4",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/about-bg.jpg", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Block4.cshtml" //view for website rendering
                    },
               }
            };
            var Block5 = new ContentBlockDefinition
            {
                Name = "Block5", //name of the block
                Id = Guid.NewGuid(),//unique id, create your own guid
                DataTypeKey = Guid.Parse("f1014aab-b021-4d57-802d-7a6985e5166d"), //datatype key for the nested content data type that was created
                PreviewImage = "/assets/img/post-bg.jpg", // Image that shows in the UI as a preview of this block. Relative path from the root of your site to an image.
                Description = "Hero Content Block5", //Description of this Content Block
                CategoryIds = new[] //List of ids of the categories this Content Block should appear in. This references the id of a IContentBlockCategory
               {
                    Perplex.ContentBlocks.Constants.Categories.Headers,
                    Perplex.ContentBlocks.Constants.Categories.Content,
                    ///_demoContentBlockCategory.Id
                },

                Layouts = new IContentBlockLayout[] //List of all layouts of this Content Block
               {
                    new ContentBlockLayout
                    {
                        Id =Guid.NewGuid(), //unique id, create your own guid
                        Name = "Block 5",//name for layout
                        Description = "Centre Aligned Text", //description
                        PreviewImage = "/assets/img/about-bg.jpg", //preview image for backoffice
                        ViewPath = "~/Views/Partials/PerplexContentBlocks/Hero/_Block5.cshtml" //view for website rendering
                    },
               }
            };

            _definitions.Add(heroBlock);
            _definitions.Add(Block1);
            _definitions.Add(Block2);
            _definitions.Add(Block3);
            _definitions.Add(Block4);
            _definitions.Add(Block5);


        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }

        ///[RuntimeLevel(MinLevel = Umbraco.Core.RuntimeLevel.Run)]
        public class ContentBlockComposer : ComponentComposer<PerplexContentBlocksComponent> { }
    }
}
