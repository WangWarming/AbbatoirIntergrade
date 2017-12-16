    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MessageBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Connections
            {
                RightConnect,
                LeftConnect
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Connections mCurrentConnectionsState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            ClipsChildren = false;
                            Height = 43.05555f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 28.125f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Middle.Height = -160f;
                            Middle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SetProperty("Middle.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            Middle.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Middle.TextureHeight = 1;
                            Middle.TextureLeft = 1990;
                            Middle.TextureTop = 1500;
                            Middle.TextureWidth = 1;
                            Middle.Width = -160f;
                            Middle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Middle.X = 0f;
                            Middle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Middle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Middle.Y = 0f;
                            Middle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Middle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TopLeft.Height = 80f;
                            TopLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("TopLeft.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            TopLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TopLeft.TextureHeight = 165;
                            TopLeft.TextureLeft = 1883;
                            TopLeft.TextureTop = 751;
                            TopLeft.TextureWidth = 165;
                            TopLeft.Width = 80f;
                            TopLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TopLeft.X = 0f;
                            TopLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TopLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TopLeft.Y = 0f;
                            TopLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            TopLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Top.Height = 80f;
                            Top.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("Top.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            Top.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Top.TextureHeight = 165;
                            Top.TextureLeft = 1785;
                            Top.TextureTop = 1256;
                            Top.TextureWidth = 46;
                            Top.Width = -160f;
                            Top.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Top.X = 0f;
                            Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Top.Y = 0f;
                            Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TopRight.Height = 80f;
                            TopRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("TopRight.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            TopRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TopRight.TextureHeight = 165;
                            TopRight.TextureLeft = 1882;
                            TopRight.TextureTop = 918;
                            TopRight.TextureWidth = 165;
                            TopRight.Width = 80f;
                            TopRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TopRight.X = 0f;
                            TopRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TopRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            TopRight.Y = 0f;
                            TopRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            TopRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Right.Height = -160f;
                            Right.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SetProperty("Right.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            Right.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Right.TextureHeight = 117;
                            Right.TextureLeft = 1715;
                            Right.TextureTop = 1423;
                            Right.TextureWidth = 165;
                            Right.Width = 80f;
                            Right.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Right.X = 0f;
                            Right.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            Right.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Right.Y = 0f;
                            Right.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Right.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BottomRight.Height = 80f;
                            BottomRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("BottomRight.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            BottomRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BottomRight.TextureHeight = 165;
                            BottomRight.TextureLeft = 1882;
                            BottomRight.TextureTop = 1256;
                            BottomRight.TextureWidth = 165;
                            BottomRight.Width = 80f;
                            BottomRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BottomRight.X = 0f;
                            BottomRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            BottomRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BottomRight.Y = 0f;
                            BottomRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BottomRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Bottom.Height = 80f;
                            Bottom.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("Bottom.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            Bottom.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Bottom.TextureHeight = 165;
                            Bottom.TextureLeft = 1833;
                            Bottom.TextureTop = 1249;
                            Bottom.TextureWidth = 2;
                            Bottom.Width = -160f;
                            Bottom.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Bottom.X = 0f;
                            Bottom.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Bottom.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Bottom.Y = 0f;
                            Bottom.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            Bottom.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BottomLeft.Height = 80f;
                            BottomLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("BottomLeft.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            BottomLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BottomLeft.TextureHeight = 165;
                            BottomLeft.TextureLeft = 1883;
                            BottomLeft.TextureTop = 1085;
                            BottomLeft.TextureWidth = 165;
                            BottomLeft.Width = 80f;
                            BottomLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BottomLeft.X = 0f;
                            BottomLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            BottomLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            BottomLeft.Y = 0f;
                            BottomLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BottomLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Left.Height = -160f;
                            Left.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            SetProperty("Left.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            Left.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Left.TextureHeight = 117;
                            Left.TextureLeft = 1884;
                            Left.TextureTop = 1426;
                            Left.TextureWidth = 165;
                            Left.Width = 80f;
                            Left.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Left.X = 0f;
                            Left.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            Left.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Left.Y = 0f;
                            Left.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Left.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public Connections CurrentConnectionsState
            {
                get
                {
                    return mCurrentConnectionsState;
                }
                set
                {
                    mCurrentConnectionsState = value;
                    switch(mCurrentConnectionsState)
                    {
                        case  Connections.RightConnect:
                            Height = 10.68727f;
                            Width = 10.01024f;
                            Middle.Width = -16f;
                            Middle.X = 4f;
                            Top.Width = -24f;
                            Top.X = 4f;
                            TopRight.Height = 16f;
                            TopRight.TextureLeft = 7;
                            TopRight.TextureTop = 100;
                            TopRight.TextureWidth = 8;
                            TopRight.Width = 8f;
                            Right.TextureWidth = 8;
                            Right.Width = 8f;
                            BottomRight.TextureLeft = 7;
                            BottomRight.TextureTop = 196;
                            BottomRight.TextureWidth = 8;
                            BottomRight.Width = 8f;
                            Bottom.Width = -24f;
                            Bottom.X = 4f;
                            break;
                        case  Connections.LeftConnect:
                            Middle.Width = -16f;
                            Middle.X = -4f;
                            TopLeft.TextureHeight = 16;
                            TopLeft.TextureLeft = 15;
                            TopLeft.TextureTop = 100;
                            TopLeft.TextureWidth = 8;
                            TopLeft.Width = 8f;
                            Top.Width = -24f;
                            Top.X = -4f;
                            Bottom.TextureWidth = 72;
                            Bottom.Width = -24f;
                            Bottom.X = -4f;
                            BottomLeft.TextureLeft = 15;
                            BottomLeft.TextureTop = 196;
                            BottomLeft.TextureWidth = 8;
                            BottomLeft.Width = 8f;
                            Left.FlipHorizontal = false;
                            Left.TextureLeft = 89;
                            Left.TextureWidth = 8;
                            Left.Width = 8f;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBottomHeightFirstValue = false;
                bool setBottomHeightSecondValue = false;
                float BottomHeightFirstValue= 0;
                float BottomHeightSecondValue= 0;
                bool setBottomTextureHeightFirstValue = false;
                bool setBottomTextureHeightSecondValue = false;
                int BottomTextureHeightFirstValue= 0;
                int BottomTextureHeightSecondValue= 0;
                bool setBottomTextureLeftFirstValue = false;
                bool setBottomTextureLeftSecondValue = false;
                int BottomTextureLeftFirstValue= 0;
                int BottomTextureLeftSecondValue= 0;
                bool setBottomTextureTopFirstValue = false;
                bool setBottomTextureTopSecondValue = false;
                int BottomTextureTopFirstValue= 0;
                int BottomTextureTopSecondValue= 0;
                bool setBottomTextureWidthFirstValue = false;
                bool setBottomTextureWidthSecondValue = false;
                int BottomTextureWidthFirstValue= 0;
                int BottomTextureWidthSecondValue= 0;
                bool setBottomWidthFirstValue = false;
                bool setBottomWidthSecondValue = false;
                float BottomWidthFirstValue= 0;
                float BottomWidthSecondValue= 0;
                bool setBottomXFirstValue = false;
                bool setBottomXSecondValue = false;
                float BottomXFirstValue= 0;
                float BottomXSecondValue= 0;
                bool setBottomYFirstValue = false;
                bool setBottomYSecondValue = false;
                float BottomYFirstValue= 0;
                float BottomYSecondValue= 0;
                bool setBottomLeftHeightFirstValue = false;
                bool setBottomLeftHeightSecondValue = false;
                float BottomLeftHeightFirstValue= 0;
                float BottomLeftHeightSecondValue= 0;
                bool setBottomLeftTextureHeightFirstValue = false;
                bool setBottomLeftTextureHeightSecondValue = false;
                int BottomLeftTextureHeightFirstValue= 0;
                int BottomLeftTextureHeightSecondValue= 0;
                bool setBottomLeftTextureLeftFirstValue = false;
                bool setBottomLeftTextureLeftSecondValue = false;
                int BottomLeftTextureLeftFirstValue= 0;
                int BottomLeftTextureLeftSecondValue= 0;
                bool setBottomLeftTextureTopFirstValue = false;
                bool setBottomLeftTextureTopSecondValue = false;
                int BottomLeftTextureTopFirstValue= 0;
                int BottomLeftTextureTopSecondValue= 0;
                bool setBottomLeftTextureWidthFirstValue = false;
                bool setBottomLeftTextureWidthSecondValue = false;
                int BottomLeftTextureWidthFirstValue= 0;
                int BottomLeftTextureWidthSecondValue= 0;
                bool setBottomLeftWidthFirstValue = false;
                bool setBottomLeftWidthSecondValue = false;
                float BottomLeftWidthFirstValue= 0;
                float BottomLeftWidthSecondValue= 0;
                bool setBottomLeftXFirstValue = false;
                bool setBottomLeftXSecondValue = false;
                float BottomLeftXFirstValue= 0;
                float BottomLeftXSecondValue= 0;
                bool setBottomLeftYFirstValue = false;
                bool setBottomLeftYSecondValue = false;
                float BottomLeftYFirstValue= 0;
                float BottomLeftYSecondValue= 0;
                bool setBottomRightHeightFirstValue = false;
                bool setBottomRightHeightSecondValue = false;
                float BottomRightHeightFirstValue= 0;
                float BottomRightHeightSecondValue= 0;
                bool setBottomRightTextureHeightFirstValue = false;
                bool setBottomRightTextureHeightSecondValue = false;
                int BottomRightTextureHeightFirstValue= 0;
                int BottomRightTextureHeightSecondValue= 0;
                bool setBottomRightTextureLeftFirstValue = false;
                bool setBottomRightTextureLeftSecondValue = false;
                int BottomRightTextureLeftFirstValue= 0;
                int BottomRightTextureLeftSecondValue= 0;
                bool setBottomRightTextureTopFirstValue = false;
                bool setBottomRightTextureTopSecondValue = false;
                int BottomRightTextureTopFirstValue= 0;
                int BottomRightTextureTopSecondValue= 0;
                bool setBottomRightTextureWidthFirstValue = false;
                bool setBottomRightTextureWidthSecondValue = false;
                int BottomRightTextureWidthFirstValue= 0;
                int BottomRightTextureWidthSecondValue= 0;
                bool setBottomRightWidthFirstValue = false;
                bool setBottomRightWidthSecondValue = false;
                float BottomRightWidthFirstValue= 0;
                float BottomRightWidthSecondValue= 0;
                bool setBottomRightXFirstValue = false;
                bool setBottomRightXSecondValue = false;
                float BottomRightXFirstValue= 0;
                float BottomRightXSecondValue= 0;
                bool setBottomRightYFirstValue = false;
                bool setBottomRightYSecondValue = false;
                float BottomRightYFirstValue= 0;
                float BottomRightYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLeftHeightFirstValue = false;
                bool setLeftHeightSecondValue = false;
                float LeftHeightFirstValue= 0;
                float LeftHeightSecondValue= 0;
                bool setLeftTextureHeightFirstValue = false;
                bool setLeftTextureHeightSecondValue = false;
                int LeftTextureHeightFirstValue= 0;
                int LeftTextureHeightSecondValue= 0;
                bool setLeftTextureLeftFirstValue = false;
                bool setLeftTextureLeftSecondValue = false;
                int LeftTextureLeftFirstValue= 0;
                int LeftTextureLeftSecondValue= 0;
                bool setLeftTextureTopFirstValue = false;
                bool setLeftTextureTopSecondValue = false;
                int LeftTextureTopFirstValue= 0;
                int LeftTextureTopSecondValue= 0;
                bool setLeftTextureWidthFirstValue = false;
                bool setLeftTextureWidthSecondValue = false;
                int LeftTextureWidthFirstValue= 0;
                int LeftTextureWidthSecondValue= 0;
                bool setLeftWidthFirstValue = false;
                bool setLeftWidthSecondValue = false;
                float LeftWidthFirstValue= 0;
                float LeftWidthSecondValue= 0;
                bool setLeftXFirstValue = false;
                bool setLeftXSecondValue = false;
                float LeftXFirstValue= 0;
                float LeftXSecondValue= 0;
                bool setLeftYFirstValue = false;
                bool setLeftYSecondValue = false;
                float LeftYFirstValue= 0;
                float LeftYSecondValue= 0;
                bool setMiddleHeightFirstValue = false;
                bool setMiddleHeightSecondValue = false;
                float MiddleHeightFirstValue= 0;
                float MiddleHeightSecondValue= 0;
                bool setMiddleTextureHeightFirstValue = false;
                bool setMiddleTextureHeightSecondValue = false;
                int MiddleTextureHeightFirstValue= 0;
                int MiddleTextureHeightSecondValue= 0;
                bool setMiddleTextureLeftFirstValue = false;
                bool setMiddleTextureLeftSecondValue = false;
                int MiddleTextureLeftFirstValue= 0;
                int MiddleTextureLeftSecondValue= 0;
                bool setMiddleTextureTopFirstValue = false;
                bool setMiddleTextureTopSecondValue = false;
                int MiddleTextureTopFirstValue= 0;
                int MiddleTextureTopSecondValue= 0;
                bool setMiddleTextureWidthFirstValue = false;
                bool setMiddleTextureWidthSecondValue = false;
                int MiddleTextureWidthFirstValue= 0;
                int MiddleTextureWidthSecondValue= 0;
                bool setMiddleWidthFirstValue = false;
                bool setMiddleWidthSecondValue = false;
                float MiddleWidthFirstValue= 0;
                float MiddleWidthSecondValue= 0;
                bool setMiddleXFirstValue = false;
                bool setMiddleXSecondValue = false;
                float MiddleXFirstValue= 0;
                float MiddleXSecondValue= 0;
                bool setMiddleYFirstValue = false;
                bool setMiddleYSecondValue = false;
                float MiddleYFirstValue= 0;
                float MiddleYSecondValue= 0;
                bool setRightHeightFirstValue = false;
                bool setRightHeightSecondValue = false;
                float RightHeightFirstValue= 0;
                float RightHeightSecondValue= 0;
                bool setRightTextureHeightFirstValue = false;
                bool setRightTextureHeightSecondValue = false;
                int RightTextureHeightFirstValue= 0;
                int RightTextureHeightSecondValue= 0;
                bool setRightTextureLeftFirstValue = false;
                bool setRightTextureLeftSecondValue = false;
                int RightTextureLeftFirstValue= 0;
                int RightTextureLeftSecondValue= 0;
                bool setRightTextureTopFirstValue = false;
                bool setRightTextureTopSecondValue = false;
                int RightTextureTopFirstValue= 0;
                int RightTextureTopSecondValue= 0;
                bool setRightTextureWidthFirstValue = false;
                bool setRightTextureWidthSecondValue = false;
                int RightTextureWidthFirstValue= 0;
                int RightTextureWidthSecondValue= 0;
                bool setRightWidthFirstValue = false;
                bool setRightWidthSecondValue = false;
                float RightWidthFirstValue= 0;
                float RightWidthSecondValue= 0;
                bool setRightXFirstValue = false;
                bool setRightXSecondValue = false;
                float RightXFirstValue= 0;
                float RightXSecondValue= 0;
                bool setRightYFirstValue = false;
                bool setRightYSecondValue = false;
                float RightYFirstValue= 0;
                float RightYSecondValue= 0;
                bool setTopHeightFirstValue = false;
                bool setTopHeightSecondValue = false;
                float TopHeightFirstValue= 0;
                float TopHeightSecondValue= 0;
                bool setTopTextureHeightFirstValue = false;
                bool setTopTextureHeightSecondValue = false;
                int TopTextureHeightFirstValue= 0;
                int TopTextureHeightSecondValue= 0;
                bool setTopTextureLeftFirstValue = false;
                bool setTopTextureLeftSecondValue = false;
                int TopTextureLeftFirstValue= 0;
                int TopTextureLeftSecondValue= 0;
                bool setTopTextureTopFirstValue = false;
                bool setTopTextureTopSecondValue = false;
                int TopTextureTopFirstValue= 0;
                int TopTextureTopSecondValue= 0;
                bool setTopTextureWidthFirstValue = false;
                bool setTopTextureWidthSecondValue = false;
                int TopTextureWidthFirstValue= 0;
                int TopTextureWidthSecondValue= 0;
                bool setTopWidthFirstValue = false;
                bool setTopWidthSecondValue = false;
                float TopWidthFirstValue= 0;
                float TopWidthSecondValue= 0;
                bool setTopXFirstValue = false;
                bool setTopXSecondValue = false;
                float TopXFirstValue= 0;
                float TopXSecondValue= 0;
                bool setTopYFirstValue = false;
                bool setTopYSecondValue = false;
                float TopYFirstValue= 0;
                float TopYSecondValue= 0;
                bool setTopLeftHeightFirstValue = false;
                bool setTopLeftHeightSecondValue = false;
                float TopLeftHeightFirstValue= 0;
                float TopLeftHeightSecondValue= 0;
                bool setTopLeftTextureHeightFirstValue = false;
                bool setTopLeftTextureHeightSecondValue = false;
                int TopLeftTextureHeightFirstValue= 0;
                int TopLeftTextureHeightSecondValue= 0;
                bool setTopLeftTextureLeftFirstValue = false;
                bool setTopLeftTextureLeftSecondValue = false;
                int TopLeftTextureLeftFirstValue= 0;
                int TopLeftTextureLeftSecondValue= 0;
                bool setTopLeftTextureTopFirstValue = false;
                bool setTopLeftTextureTopSecondValue = false;
                int TopLeftTextureTopFirstValue= 0;
                int TopLeftTextureTopSecondValue= 0;
                bool setTopLeftTextureWidthFirstValue = false;
                bool setTopLeftTextureWidthSecondValue = false;
                int TopLeftTextureWidthFirstValue= 0;
                int TopLeftTextureWidthSecondValue= 0;
                bool setTopLeftWidthFirstValue = false;
                bool setTopLeftWidthSecondValue = false;
                float TopLeftWidthFirstValue= 0;
                float TopLeftWidthSecondValue= 0;
                bool setTopLeftXFirstValue = false;
                bool setTopLeftXSecondValue = false;
                float TopLeftXFirstValue= 0;
                float TopLeftXSecondValue= 0;
                bool setTopLeftYFirstValue = false;
                bool setTopLeftYSecondValue = false;
                float TopLeftYFirstValue= 0;
                float TopLeftYSecondValue= 0;
                bool setTopRightHeightFirstValue = false;
                bool setTopRightHeightSecondValue = false;
                float TopRightHeightFirstValue= 0;
                float TopRightHeightSecondValue= 0;
                bool setTopRightTextureHeightFirstValue = false;
                bool setTopRightTextureHeightSecondValue = false;
                int TopRightTextureHeightFirstValue= 0;
                int TopRightTextureHeightSecondValue= 0;
                bool setTopRightTextureLeftFirstValue = false;
                bool setTopRightTextureLeftSecondValue = false;
                int TopRightTextureLeftFirstValue= 0;
                int TopRightTextureLeftSecondValue= 0;
                bool setTopRightTextureTopFirstValue = false;
                bool setTopRightTextureTopSecondValue = false;
                int TopRightTextureTopFirstValue= 0;
                int TopRightTextureTopSecondValue= 0;
                bool setTopRightTextureWidthFirstValue = false;
                bool setTopRightTextureWidthSecondValue = false;
                int TopRightTextureWidthFirstValue= 0;
                int TopRightTextureWidthSecondValue= 0;
                bool setTopRightWidthFirstValue = false;
                bool setTopRightWidthSecondValue = false;
                float TopRightWidthFirstValue= 0;
                float TopRightWidthSecondValue= 0;
                bool setTopRightXFirstValue = false;
                bool setTopRightXSecondValue = false;
                float TopRightXFirstValue= 0;
                float TopRightXSecondValue= 0;
                bool setTopRightYFirstValue = false;
                bool setTopRightYSecondValue = false;
                float TopRightYFirstValue= 0;
                float TopRightYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBottomHeightFirstValue = true;
                        BottomHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("Bottom.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Bottom.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomTextureHeightFirstValue = true;
                        BottomTextureHeightFirstValue = 165;
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 1833;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 1249;
                        setBottomTextureWidthFirstValue = true;
                        BottomTextureWidthFirstValue = 2;
                        setBottomWidthFirstValue = true;
                        BottomWidthFirstValue = -160f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBottomXFirstValue = true;
                        BottomXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Bottom.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBottomYFirstValue = true;
                        BottomYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Bottom.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomLeftHeightFirstValue = true;
                        BottomLeftHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("BottomLeft.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomLeftTextureHeightFirstValue = true;
                        BottomLeftTextureHeightFirstValue = 165;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 1883;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 1085;
                        setBottomLeftTextureWidthFirstValue = true;
                        BottomLeftTextureWidthFirstValue = 165;
                        setBottomLeftWidthFirstValue = true;
                        BottomLeftWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomLeftXFirstValue = true;
                        BottomLeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setBottomLeftYFirstValue = true;
                        BottomLeftYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightHeightFirstValue = true;
                        BottomRightHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("BottomRight.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomRightTextureHeightFirstValue = true;
                        BottomRightTextureHeightFirstValue = 165;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 1882;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 1256;
                        setBottomRightTextureWidthFirstValue = true;
                        BottomRightTextureWidthFirstValue = 165;
                        setBottomRightWidthFirstValue = true;
                        BottomRightWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRightXFirstValue = true;
                        BottomRightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightYFirstValue = true;
                        BottomRightYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 43.05555f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLeftHeightFirstValue = true;
                        LeftHeightFirstValue = -160f;
                        if (interpolationValue < 1)
                        {
                            this.Left.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("Left.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Left.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLeftTextureHeightFirstValue = true;
                        LeftTextureHeightFirstValue = 117;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 1884;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 1426;
                        setLeftTextureWidthFirstValue = true;
                        LeftTextureWidthFirstValue = 165;
                        setLeftWidthFirstValue = true;
                        LeftWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.Left.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLeftXFirstValue = true;
                        LeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Left.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Left.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setLeftYFirstValue = true;
                        LeftYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Left.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Left.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleHeightFirstValue = true;
                        MiddleHeightFirstValue = -160f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("Middle.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Middle.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleTextureHeightFirstValue = true;
                        MiddleTextureHeightFirstValue = 1;
                        setMiddleTextureLeftFirstValue = true;
                        MiddleTextureLeftFirstValue = 1990;
                        setMiddleTextureTopFirstValue = true;
                        MiddleTextureTopFirstValue = 1500;
                        setMiddleTextureWidthFirstValue = true;
                        MiddleTextureWidthFirstValue = 1;
                        setMiddleWidthFirstValue = true;
                        MiddleWidthFirstValue = -160f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMiddleXFirstValue = true;
                        MiddleXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Middle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleYFirstValue = true;
                        MiddleYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Middle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightHeightFirstValue = true;
                        RightHeightFirstValue = -160f;
                        if (interpolationValue < 1)
                        {
                            this.Right.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("Right.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Right.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRightTextureHeightFirstValue = true;
                        RightTextureHeightFirstValue = 117;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 1715;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 1423;
                        setRightTextureWidthFirstValue = true;
                        RightTextureWidthFirstValue = 165;
                        setRightWidthFirstValue = true;
                        RightWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.Right.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setRightXFirstValue = true;
                        RightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Right.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Right.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightYFirstValue = true;
                        RightYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Right.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Right.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopHeightFirstValue = true;
                        TopHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.Top.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("Top.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopTextureHeightFirstValue = true;
                        TopTextureHeightFirstValue = 165;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 1785;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 1256;
                        setTopTextureWidthFirstValue = true;
                        TopTextureWidthFirstValue = 46;
                        setTopWidthFirstValue = true;
                        TopWidthFirstValue = -160f;
                        if (interpolationValue < 1)
                        {
                            this.Top.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTopXFirstValue = true;
                        TopXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopYFirstValue = true;
                        TopYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftHeightFirstValue = true;
                        TopLeftHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TopLeft.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopLeftTextureHeightFirstValue = true;
                        TopLeftTextureHeightFirstValue = 165;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 1883;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 751;
                        setTopLeftTextureWidthFirstValue = true;
                        TopLeftTextureWidthFirstValue = 165;
                        setTopLeftWidthFirstValue = true;
                        TopLeftWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopLeftXFirstValue = true;
                        TopLeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftYFirstValue = true;
                        TopLeftYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopRightHeightFirstValue = true;
                        TopRightHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TopRight.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopRightTextureHeightFirstValue = true;
                        TopRightTextureHeightFirstValue = 165;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 1882;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 918;
                        setTopRightTextureWidthFirstValue = true;
                        TopRightTextureWidthFirstValue = 165;
                        setTopRightWidthFirstValue = true;
                        TopRightWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRightXFirstValue = true;
                        TopRightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTopRightYFirstValue = true;
                        TopRightYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 28.125f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBottomHeightSecondValue = true;
                        BottomHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Bottom.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomTextureHeightSecondValue = true;
                        BottomTextureHeightSecondValue = 165;
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 1833;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 1249;
                        setBottomTextureWidthSecondValue = true;
                        BottomTextureWidthSecondValue = 2;
                        setBottomWidthSecondValue = true;
                        BottomWidthSecondValue = -160f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBottomXSecondValue = true;
                        BottomXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBottomYSecondValue = true;
                        BottomYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomLeftHeightSecondValue = true;
                        BottomLeftHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BottomLeft.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomLeftTextureHeightSecondValue = true;
                        BottomLeftTextureHeightSecondValue = 165;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 1883;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 1085;
                        setBottomLeftTextureWidthSecondValue = true;
                        BottomLeftTextureWidthSecondValue = 165;
                        setBottomLeftWidthSecondValue = true;
                        BottomLeftWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomLeftXSecondValue = true;
                        BottomLeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setBottomLeftYSecondValue = true;
                        BottomLeftYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightHeightSecondValue = true;
                        BottomRightHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BottomRight.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomRightTextureHeightSecondValue = true;
                        BottomRightTextureHeightSecondValue = 165;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 1882;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 1256;
                        setBottomRightTextureWidthSecondValue = true;
                        BottomRightTextureWidthSecondValue = 165;
                        setBottomRightWidthSecondValue = true;
                        BottomRightWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRightXSecondValue = true;
                        BottomRightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightYSecondValue = true;
                        BottomRightYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 43.05555f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLeftHeightSecondValue = true;
                        LeftHeightSecondValue = -160f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Left.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Left.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLeftTextureHeightSecondValue = true;
                        LeftTextureHeightSecondValue = 117;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 1884;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 1426;
                        setLeftTextureWidthSecondValue = true;
                        LeftTextureWidthSecondValue = 165;
                        setLeftWidthSecondValue = true;
                        LeftWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLeftXSecondValue = true;
                        LeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Left.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setLeftYSecondValue = true;
                        LeftYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Left.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleHeightSecondValue = true;
                        MiddleHeightSecondValue = -160f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Middle.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Middle.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleTextureHeightSecondValue = true;
                        MiddleTextureHeightSecondValue = 1;
                        setMiddleTextureLeftSecondValue = true;
                        MiddleTextureLeftSecondValue = 1990;
                        setMiddleTextureTopSecondValue = true;
                        MiddleTextureTopSecondValue = 1500;
                        setMiddleTextureWidthSecondValue = true;
                        MiddleTextureWidthSecondValue = 1;
                        setMiddleWidthSecondValue = true;
                        MiddleWidthSecondValue = -160f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMiddleXSecondValue = true;
                        MiddleXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Middle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleYSecondValue = true;
                        MiddleYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Middle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightHeightSecondValue = true;
                        RightHeightSecondValue = -160f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Right.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Right.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRightTextureHeightSecondValue = true;
                        RightTextureHeightSecondValue = 117;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 1715;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 1423;
                        setRightTextureWidthSecondValue = true;
                        RightTextureWidthSecondValue = 165;
                        setRightWidthSecondValue = true;
                        RightWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setRightXSecondValue = true;
                        RightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Right.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightYSecondValue = true;
                        RightYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Right.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopHeightSecondValue = true;
                        TopHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Top.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopTextureHeightSecondValue = true;
                        TopTextureHeightSecondValue = 165;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 1785;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 1256;
                        setTopTextureWidthSecondValue = true;
                        TopTextureWidthSecondValue = 46;
                        setTopWidthSecondValue = true;
                        TopWidthSecondValue = -160f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTopXSecondValue = true;
                        TopXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopYSecondValue = true;
                        TopYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftHeightSecondValue = true;
                        TopLeftHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TopLeft.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopLeftTextureHeightSecondValue = true;
                        TopLeftTextureHeightSecondValue = 165;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 1883;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 751;
                        setTopLeftTextureWidthSecondValue = true;
                        TopLeftTextureWidthSecondValue = 165;
                        setTopLeftWidthSecondValue = true;
                        TopLeftWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopLeftXSecondValue = true;
                        TopLeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftYSecondValue = true;
                        TopLeftYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopRightHeightSecondValue = true;
                        TopRightHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TopRight.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopRightTextureHeightSecondValue = true;
                        TopRightTextureHeightSecondValue = 165;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 1882;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 918;
                        setTopRightTextureWidthSecondValue = true;
                        TopRightTextureWidthSecondValue = 165;
                        setTopRightWidthSecondValue = true;
                        TopRightWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRightXSecondValue = true;
                        TopRightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTopRightYSecondValue = true;
                        TopRightYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 28.125f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setBottomHeightFirstValue && setBottomHeightSecondValue)
                {
                    Bottom.Height = BottomHeightFirstValue * (1 - interpolationValue) + BottomHeightSecondValue * interpolationValue;
                }
                if (setBottomTextureHeightFirstValue && setBottomTextureHeightSecondValue)
                {
                    Bottom.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureHeightFirstValue* (1 - interpolationValue) + BottomTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomTextureLeftFirstValue && setBottomTextureLeftSecondValue)
                {
                    Bottom.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureLeftFirstValue* (1 - interpolationValue) + BottomTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomTextureTopFirstValue && setBottomTextureTopSecondValue)
                {
                    Bottom.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureTopFirstValue* (1 - interpolationValue) + BottomTextureTopSecondValue * interpolationValue);
                }
                if (setBottomTextureWidthFirstValue && setBottomTextureWidthSecondValue)
                {
                    Bottom.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureWidthFirstValue* (1 - interpolationValue) + BottomTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomWidthFirstValue && setBottomWidthSecondValue)
                {
                    Bottom.Width = BottomWidthFirstValue * (1 - interpolationValue) + BottomWidthSecondValue * interpolationValue;
                }
                if (setBottomXFirstValue && setBottomXSecondValue)
                {
                    Bottom.X = BottomXFirstValue * (1 - interpolationValue) + BottomXSecondValue * interpolationValue;
                }
                if (setBottomYFirstValue && setBottomYSecondValue)
                {
                    Bottom.Y = BottomYFirstValue * (1 - interpolationValue) + BottomYSecondValue * interpolationValue;
                }
                if (setBottomLeftHeightFirstValue && setBottomLeftHeightSecondValue)
                {
                    BottomLeft.Height = BottomLeftHeightFirstValue * (1 - interpolationValue) + BottomLeftHeightSecondValue * interpolationValue;
                }
                if (setBottomLeftTextureHeightFirstValue && setBottomLeftTextureHeightSecondValue)
                {
                    BottomLeft.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureHeightFirstValue* (1 - interpolationValue) + BottomLeftTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureLeftFirstValue && setBottomLeftTextureLeftSecondValue)
                {
                    BottomLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureLeftFirstValue* (1 - interpolationValue) + BottomLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureTopFirstValue && setBottomLeftTextureTopSecondValue)
                {
                    BottomLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureTopFirstValue* (1 - interpolationValue) + BottomLeftTextureTopSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureWidthFirstValue && setBottomLeftTextureWidthSecondValue)
                {
                    BottomLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureWidthFirstValue* (1 - interpolationValue) + BottomLeftTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomLeftWidthFirstValue && setBottomLeftWidthSecondValue)
                {
                    BottomLeft.Width = BottomLeftWidthFirstValue * (1 - interpolationValue) + BottomLeftWidthSecondValue * interpolationValue;
                }
                if (setBottomLeftXFirstValue && setBottomLeftXSecondValue)
                {
                    BottomLeft.X = BottomLeftXFirstValue * (1 - interpolationValue) + BottomLeftXSecondValue * interpolationValue;
                }
                if (setBottomLeftYFirstValue && setBottomLeftYSecondValue)
                {
                    BottomLeft.Y = BottomLeftYFirstValue * (1 - interpolationValue) + BottomLeftYSecondValue * interpolationValue;
                }
                if (setBottomRightHeightFirstValue && setBottomRightHeightSecondValue)
                {
                    BottomRight.Height = BottomRightHeightFirstValue * (1 - interpolationValue) + BottomRightHeightSecondValue * interpolationValue;
                }
                if (setBottomRightTextureHeightFirstValue && setBottomRightTextureHeightSecondValue)
                {
                    BottomRight.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureHeightFirstValue* (1 - interpolationValue) + BottomRightTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomRightTextureLeftFirstValue && setBottomRightTextureLeftSecondValue)
                {
                    BottomRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureLeftFirstValue* (1 - interpolationValue) + BottomRightTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomRightTextureTopFirstValue && setBottomRightTextureTopSecondValue)
                {
                    BottomRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureTopFirstValue* (1 - interpolationValue) + BottomRightTextureTopSecondValue * interpolationValue);
                }
                if (setBottomRightTextureWidthFirstValue && setBottomRightTextureWidthSecondValue)
                {
                    BottomRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureWidthFirstValue* (1 - interpolationValue) + BottomRightTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomRightWidthFirstValue && setBottomRightWidthSecondValue)
                {
                    BottomRight.Width = BottomRightWidthFirstValue * (1 - interpolationValue) + BottomRightWidthSecondValue * interpolationValue;
                }
                if (setBottomRightXFirstValue && setBottomRightXSecondValue)
                {
                    BottomRight.X = BottomRightXFirstValue * (1 - interpolationValue) + BottomRightXSecondValue * interpolationValue;
                }
                if (setBottomRightYFirstValue && setBottomRightYSecondValue)
                {
                    BottomRight.Y = BottomRightYFirstValue * (1 - interpolationValue) + BottomRightYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLeftHeightFirstValue && setLeftHeightSecondValue)
                {
                    Left.Height = LeftHeightFirstValue * (1 - interpolationValue) + LeftHeightSecondValue * interpolationValue;
                }
                if (setLeftTextureHeightFirstValue && setLeftTextureHeightSecondValue)
                {
                    Left.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureHeightFirstValue* (1 - interpolationValue) + LeftTextureHeightSecondValue * interpolationValue);
                }
                if (setLeftTextureLeftFirstValue && setLeftTextureLeftSecondValue)
                {
                    Left.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureLeftFirstValue* (1 - interpolationValue) + LeftTextureLeftSecondValue * interpolationValue);
                }
                if (setLeftTextureTopFirstValue && setLeftTextureTopSecondValue)
                {
                    Left.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureTopFirstValue* (1 - interpolationValue) + LeftTextureTopSecondValue * interpolationValue);
                }
                if (setLeftTextureWidthFirstValue && setLeftTextureWidthSecondValue)
                {
                    Left.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureWidthFirstValue* (1 - interpolationValue) + LeftTextureWidthSecondValue * interpolationValue);
                }
                if (setLeftWidthFirstValue && setLeftWidthSecondValue)
                {
                    Left.Width = LeftWidthFirstValue * (1 - interpolationValue) + LeftWidthSecondValue * interpolationValue;
                }
                if (setLeftXFirstValue && setLeftXSecondValue)
                {
                    Left.X = LeftXFirstValue * (1 - interpolationValue) + LeftXSecondValue * interpolationValue;
                }
                if (setLeftYFirstValue && setLeftYSecondValue)
                {
                    Left.Y = LeftYFirstValue * (1 - interpolationValue) + LeftYSecondValue * interpolationValue;
                }
                if (setMiddleHeightFirstValue && setMiddleHeightSecondValue)
                {
                    Middle.Height = MiddleHeightFirstValue * (1 - interpolationValue) + MiddleHeightSecondValue * interpolationValue;
                }
                if (setMiddleTextureHeightFirstValue && setMiddleTextureHeightSecondValue)
                {
                    Middle.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureHeightFirstValue* (1 - interpolationValue) + MiddleTextureHeightSecondValue * interpolationValue);
                }
                if (setMiddleTextureLeftFirstValue && setMiddleTextureLeftSecondValue)
                {
                    Middle.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureLeftFirstValue* (1 - interpolationValue) + MiddleTextureLeftSecondValue * interpolationValue);
                }
                if (setMiddleTextureTopFirstValue && setMiddleTextureTopSecondValue)
                {
                    Middle.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureTopFirstValue* (1 - interpolationValue) + MiddleTextureTopSecondValue * interpolationValue);
                }
                if (setMiddleTextureWidthFirstValue && setMiddleTextureWidthSecondValue)
                {
                    Middle.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureWidthFirstValue* (1 - interpolationValue) + MiddleTextureWidthSecondValue * interpolationValue);
                }
                if (setMiddleWidthFirstValue && setMiddleWidthSecondValue)
                {
                    Middle.Width = MiddleWidthFirstValue * (1 - interpolationValue) + MiddleWidthSecondValue * interpolationValue;
                }
                if (setMiddleXFirstValue && setMiddleXSecondValue)
                {
                    Middle.X = MiddleXFirstValue * (1 - interpolationValue) + MiddleXSecondValue * interpolationValue;
                }
                if (setMiddleYFirstValue && setMiddleYSecondValue)
                {
                    Middle.Y = MiddleYFirstValue * (1 - interpolationValue) + MiddleYSecondValue * interpolationValue;
                }
                if (setRightHeightFirstValue && setRightHeightSecondValue)
                {
                    Right.Height = RightHeightFirstValue * (1 - interpolationValue) + RightHeightSecondValue * interpolationValue;
                }
                if (setRightTextureHeightFirstValue && setRightTextureHeightSecondValue)
                {
                    Right.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureHeightFirstValue* (1 - interpolationValue) + RightTextureHeightSecondValue * interpolationValue);
                }
                if (setRightTextureLeftFirstValue && setRightTextureLeftSecondValue)
                {
                    Right.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureLeftFirstValue* (1 - interpolationValue) + RightTextureLeftSecondValue * interpolationValue);
                }
                if (setRightTextureTopFirstValue && setRightTextureTopSecondValue)
                {
                    Right.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureTopFirstValue* (1 - interpolationValue) + RightTextureTopSecondValue * interpolationValue);
                }
                if (setRightTextureWidthFirstValue && setRightTextureWidthSecondValue)
                {
                    Right.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureWidthFirstValue* (1 - interpolationValue) + RightTextureWidthSecondValue * interpolationValue);
                }
                if (setRightWidthFirstValue && setRightWidthSecondValue)
                {
                    Right.Width = RightWidthFirstValue * (1 - interpolationValue) + RightWidthSecondValue * interpolationValue;
                }
                if (setRightXFirstValue && setRightXSecondValue)
                {
                    Right.X = RightXFirstValue * (1 - interpolationValue) + RightXSecondValue * interpolationValue;
                }
                if (setRightYFirstValue && setRightYSecondValue)
                {
                    Right.Y = RightYFirstValue * (1 - interpolationValue) + RightYSecondValue * interpolationValue;
                }
                if (setTopHeightFirstValue && setTopHeightSecondValue)
                {
                    Top.Height = TopHeightFirstValue * (1 - interpolationValue) + TopHeightSecondValue * interpolationValue;
                }
                if (setTopTextureHeightFirstValue && setTopTextureHeightSecondValue)
                {
                    Top.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureHeightFirstValue* (1 - interpolationValue) + TopTextureHeightSecondValue * interpolationValue);
                }
                if (setTopTextureLeftFirstValue && setTopTextureLeftSecondValue)
                {
                    Top.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureLeftFirstValue* (1 - interpolationValue) + TopTextureLeftSecondValue * interpolationValue);
                }
                if (setTopTextureTopFirstValue && setTopTextureTopSecondValue)
                {
                    Top.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureTopFirstValue* (1 - interpolationValue) + TopTextureTopSecondValue * interpolationValue);
                }
                if (setTopTextureWidthFirstValue && setTopTextureWidthSecondValue)
                {
                    Top.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureWidthFirstValue* (1 - interpolationValue) + TopTextureWidthSecondValue * interpolationValue);
                }
                if (setTopWidthFirstValue && setTopWidthSecondValue)
                {
                    Top.Width = TopWidthFirstValue * (1 - interpolationValue) + TopWidthSecondValue * interpolationValue;
                }
                if (setTopXFirstValue && setTopXSecondValue)
                {
                    Top.X = TopXFirstValue * (1 - interpolationValue) + TopXSecondValue * interpolationValue;
                }
                if (setTopYFirstValue && setTopYSecondValue)
                {
                    Top.Y = TopYFirstValue * (1 - interpolationValue) + TopYSecondValue * interpolationValue;
                }
                if (setTopLeftHeightFirstValue && setTopLeftHeightSecondValue)
                {
                    TopLeft.Height = TopLeftHeightFirstValue * (1 - interpolationValue) + TopLeftHeightSecondValue * interpolationValue;
                }
                if (setTopLeftTextureHeightFirstValue && setTopLeftTextureHeightSecondValue)
                {
                    TopLeft.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureHeightFirstValue* (1 - interpolationValue) + TopLeftTextureHeightSecondValue * interpolationValue);
                }
                if (setTopLeftTextureLeftFirstValue && setTopLeftTextureLeftSecondValue)
                {
                    TopLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureLeftFirstValue* (1 - interpolationValue) + TopLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setTopLeftTextureTopFirstValue && setTopLeftTextureTopSecondValue)
                {
                    TopLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureTopFirstValue* (1 - interpolationValue) + TopLeftTextureTopSecondValue * interpolationValue);
                }
                if (setTopLeftTextureWidthFirstValue && setTopLeftTextureWidthSecondValue)
                {
                    TopLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureWidthFirstValue* (1 - interpolationValue) + TopLeftTextureWidthSecondValue * interpolationValue);
                }
                if (setTopLeftWidthFirstValue && setTopLeftWidthSecondValue)
                {
                    TopLeft.Width = TopLeftWidthFirstValue * (1 - interpolationValue) + TopLeftWidthSecondValue * interpolationValue;
                }
                if (setTopLeftXFirstValue && setTopLeftXSecondValue)
                {
                    TopLeft.X = TopLeftXFirstValue * (1 - interpolationValue) + TopLeftXSecondValue * interpolationValue;
                }
                if (setTopLeftYFirstValue && setTopLeftYSecondValue)
                {
                    TopLeft.Y = TopLeftYFirstValue * (1 - interpolationValue) + TopLeftYSecondValue * interpolationValue;
                }
                if (setTopRightHeightFirstValue && setTopRightHeightSecondValue)
                {
                    TopRight.Height = TopRightHeightFirstValue * (1 - interpolationValue) + TopRightHeightSecondValue * interpolationValue;
                }
                if (setTopRightTextureHeightFirstValue && setTopRightTextureHeightSecondValue)
                {
                    TopRight.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureHeightFirstValue* (1 - interpolationValue) + TopRightTextureHeightSecondValue * interpolationValue);
                }
                if (setTopRightTextureLeftFirstValue && setTopRightTextureLeftSecondValue)
                {
                    TopRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureLeftFirstValue* (1 - interpolationValue) + TopRightTextureLeftSecondValue * interpolationValue);
                }
                if (setTopRightTextureTopFirstValue && setTopRightTextureTopSecondValue)
                {
                    TopRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureTopFirstValue* (1 - interpolationValue) + TopRightTextureTopSecondValue * interpolationValue);
                }
                if (setTopRightTextureWidthFirstValue && setTopRightTextureWidthSecondValue)
                {
                    TopRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureWidthFirstValue* (1 - interpolationValue) + TopRightTextureWidthSecondValue * interpolationValue);
                }
                if (setTopRightWidthFirstValue && setTopRightWidthSecondValue)
                {
                    TopRight.Width = TopRightWidthFirstValue * (1 - interpolationValue) + TopRightWidthSecondValue * interpolationValue;
                }
                if (setTopRightXFirstValue && setTopRightXSecondValue)
                {
                    TopRight.X = TopRightXFirstValue * (1 - interpolationValue) + TopRightXSecondValue * interpolationValue;
                }
                if (setTopRightYFirstValue && setTopRightYSecondValue)
                {
                    TopRight.Y = TopRightYFirstValue * (1 - interpolationValue) + TopRightYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
            }
            public void InterpolateBetween (Connections firstState, Connections secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBottomWidthFirstValue = false;
                bool setBottomWidthSecondValue = false;
                float BottomWidthFirstValue= 0;
                float BottomWidthSecondValue= 0;
                bool setBottomXFirstValue = false;
                bool setBottomXSecondValue = false;
                float BottomXFirstValue= 0;
                float BottomXSecondValue= 0;
                bool setBottomRightTextureLeftFirstValue = false;
                bool setBottomRightTextureLeftSecondValue = false;
                int BottomRightTextureLeftFirstValue= 0;
                int BottomRightTextureLeftSecondValue= 0;
                bool setBottomRightTextureTopFirstValue = false;
                bool setBottomRightTextureTopSecondValue = false;
                int BottomRightTextureTopFirstValue= 0;
                int BottomRightTextureTopSecondValue= 0;
                bool setBottomRightTextureWidthFirstValue = false;
                bool setBottomRightTextureWidthSecondValue = false;
                int BottomRightTextureWidthFirstValue= 0;
                int BottomRightTextureWidthSecondValue= 0;
                bool setBottomRightWidthFirstValue = false;
                bool setBottomRightWidthSecondValue = false;
                float BottomRightWidthFirstValue= 0;
                float BottomRightWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMiddleWidthFirstValue = false;
                bool setMiddleWidthSecondValue = false;
                float MiddleWidthFirstValue= 0;
                float MiddleWidthSecondValue= 0;
                bool setMiddleXFirstValue = false;
                bool setMiddleXSecondValue = false;
                float MiddleXFirstValue= 0;
                float MiddleXSecondValue= 0;
                bool setRightTextureWidthFirstValue = false;
                bool setRightTextureWidthSecondValue = false;
                int RightTextureWidthFirstValue= 0;
                int RightTextureWidthSecondValue= 0;
                bool setRightWidthFirstValue = false;
                bool setRightWidthSecondValue = false;
                float RightWidthFirstValue= 0;
                float RightWidthSecondValue= 0;
                bool setTopWidthFirstValue = false;
                bool setTopWidthSecondValue = false;
                float TopWidthFirstValue= 0;
                float TopWidthSecondValue= 0;
                bool setTopXFirstValue = false;
                bool setTopXSecondValue = false;
                float TopXFirstValue= 0;
                float TopXSecondValue= 0;
                bool setTopRightHeightFirstValue = false;
                bool setTopRightHeightSecondValue = false;
                float TopRightHeightFirstValue= 0;
                float TopRightHeightSecondValue= 0;
                bool setTopRightTextureLeftFirstValue = false;
                bool setTopRightTextureLeftSecondValue = false;
                int TopRightTextureLeftFirstValue= 0;
                int TopRightTextureLeftSecondValue= 0;
                bool setTopRightTextureTopFirstValue = false;
                bool setTopRightTextureTopSecondValue = false;
                int TopRightTextureTopFirstValue= 0;
                int TopRightTextureTopSecondValue= 0;
                bool setTopRightTextureWidthFirstValue = false;
                bool setTopRightTextureWidthSecondValue = false;
                int TopRightTextureWidthFirstValue= 0;
                int TopRightTextureWidthSecondValue= 0;
                bool setTopRightWidthFirstValue = false;
                bool setTopRightWidthSecondValue = false;
                float TopRightWidthFirstValue= 0;
                float TopRightWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setBottomTextureWidthFirstValue = false;
                bool setBottomTextureWidthSecondValue = false;
                int BottomTextureWidthFirstValue= 0;
                int BottomTextureWidthSecondValue= 0;
                bool setBottomLeftTextureLeftFirstValue = false;
                bool setBottomLeftTextureLeftSecondValue = false;
                int BottomLeftTextureLeftFirstValue= 0;
                int BottomLeftTextureLeftSecondValue= 0;
                bool setBottomLeftTextureTopFirstValue = false;
                bool setBottomLeftTextureTopSecondValue = false;
                int BottomLeftTextureTopFirstValue= 0;
                int BottomLeftTextureTopSecondValue= 0;
                bool setBottomLeftTextureWidthFirstValue = false;
                bool setBottomLeftTextureWidthSecondValue = false;
                int BottomLeftTextureWidthFirstValue= 0;
                int BottomLeftTextureWidthSecondValue= 0;
                bool setBottomLeftWidthFirstValue = false;
                bool setBottomLeftWidthSecondValue = false;
                float BottomLeftWidthFirstValue= 0;
                float BottomLeftWidthSecondValue= 0;
                bool setLeftTextureLeftFirstValue = false;
                bool setLeftTextureLeftSecondValue = false;
                int LeftTextureLeftFirstValue= 0;
                int LeftTextureLeftSecondValue= 0;
                bool setLeftTextureWidthFirstValue = false;
                bool setLeftTextureWidthSecondValue = false;
                int LeftTextureWidthFirstValue= 0;
                int LeftTextureWidthSecondValue= 0;
                bool setLeftWidthFirstValue = false;
                bool setLeftWidthSecondValue = false;
                float LeftWidthFirstValue= 0;
                float LeftWidthSecondValue= 0;
                bool setTopLeftTextureHeightFirstValue = false;
                bool setTopLeftTextureHeightSecondValue = false;
                int TopLeftTextureHeightFirstValue= 0;
                int TopLeftTextureHeightSecondValue= 0;
                bool setTopLeftTextureLeftFirstValue = false;
                bool setTopLeftTextureLeftSecondValue = false;
                int TopLeftTextureLeftFirstValue= 0;
                int TopLeftTextureLeftSecondValue= 0;
                bool setTopLeftTextureTopFirstValue = false;
                bool setTopLeftTextureTopSecondValue = false;
                int TopLeftTextureTopFirstValue= 0;
                int TopLeftTextureTopSecondValue= 0;
                bool setTopLeftTextureWidthFirstValue = false;
                bool setTopLeftTextureWidthSecondValue = false;
                int TopLeftTextureWidthFirstValue= 0;
                int TopLeftTextureWidthSecondValue= 0;
                bool setTopLeftWidthFirstValue = false;
                bool setTopLeftWidthSecondValue = false;
                float TopLeftWidthFirstValue= 0;
                float TopLeftWidthSecondValue= 0;
                switch(firstState)
                {
                    case  Connections.RightConnect:
                        setBottomWidthFirstValue = true;
                        BottomWidthFirstValue = -24f;
                        setBottomXFirstValue = true;
                        BottomXFirstValue = 4f;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 7;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 196;
                        setBottomRightTextureWidthFirstValue = true;
                        BottomRightTextureWidthFirstValue = 8;
                        setBottomRightWidthFirstValue = true;
                        BottomRightWidthFirstValue = 8f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 10.68727f;
                        setMiddleWidthFirstValue = true;
                        MiddleWidthFirstValue = -16f;
                        setMiddleXFirstValue = true;
                        MiddleXFirstValue = 4f;
                        setRightTextureWidthFirstValue = true;
                        RightTextureWidthFirstValue = 8;
                        setRightWidthFirstValue = true;
                        RightWidthFirstValue = 8f;
                        setTopWidthFirstValue = true;
                        TopWidthFirstValue = -24f;
                        setTopXFirstValue = true;
                        TopXFirstValue = 4f;
                        setTopRightHeightFirstValue = true;
                        TopRightHeightFirstValue = 16f;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 7;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 100;
                        setTopRightTextureWidthFirstValue = true;
                        TopRightTextureWidthFirstValue = 8;
                        setTopRightWidthFirstValue = true;
                        TopRightWidthFirstValue = 8f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 10.01024f;
                        break;
                    case  Connections.LeftConnect:
                        setBottomTextureWidthFirstValue = true;
                        BottomTextureWidthFirstValue = 72;
                        setBottomWidthFirstValue = true;
                        BottomWidthFirstValue = -24f;
                        setBottomXFirstValue = true;
                        BottomXFirstValue = -4f;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 15;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 196;
                        setBottomLeftTextureWidthFirstValue = true;
                        BottomLeftTextureWidthFirstValue = 8;
                        setBottomLeftWidthFirstValue = true;
                        BottomLeftWidthFirstValue = 8f;
                        if (interpolationValue < 1)
                        {
                            this.Left.FlipHorizontal = false;
                        }
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 89;
                        setLeftTextureWidthFirstValue = true;
                        LeftTextureWidthFirstValue = 8;
                        setLeftWidthFirstValue = true;
                        LeftWidthFirstValue = 8f;
                        setMiddleWidthFirstValue = true;
                        MiddleWidthFirstValue = -16f;
                        setMiddleXFirstValue = true;
                        MiddleXFirstValue = -4f;
                        setTopWidthFirstValue = true;
                        TopWidthFirstValue = -24f;
                        setTopXFirstValue = true;
                        TopXFirstValue = -4f;
                        setTopLeftTextureHeightFirstValue = true;
                        TopLeftTextureHeightFirstValue = 16;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 15;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 100;
                        setTopLeftTextureWidthFirstValue = true;
                        TopLeftTextureWidthFirstValue = 8;
                        setTopLeftWidthFirstValue = true;
                        TopLeftWidthFirstValue = 8f;
                        break;
                }
                switch(secondState)
                {
                    case  Connections.RightConnect:
                        setBottomWidthSecondValue = true;
                        BottomWidthSecondValue = -24f;
                        setBottomXSecondValue = true;
                        BottomXSecondValue = 4f;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 7;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 196;
                        setBottomRightTextureWidthSecondValue = true;
                        BottomRightTextureWidthSecondValue = 8;
                        setBottomRightWidthSecondValue = true;
                        BottomRightWidthSecondValue = 8f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 10.68727f;
                        setMiddleWidthSecondValue = true;
                        MiddleWidthSecondValue = -16f;
                        setMiddleXSecondValue = true;
                        MiddleXSecondValue = 4f;
                        setRightTextureWidthSecondValue = true;
                        RightTextureWidthSecondValue = 8;
                        setRightWidthSecondValue = true;
                        RightWidthSecondValue = 8f;
                        setTopWidthSecondValue = true;
                        TopWidthSecondValue = -24f;
                        setTopXSecondValue = true;
                        TopXSecondValue = 4f;
                        setTopRightHeightSecondValue = true;
                        TopRightHeightSecondValue = 16f;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 7;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 100;
                        setTopRightTextureWidthSecondValue = true;
                        TopRightTextureWidthSecondValue = 8;
                        setTopRightWidthSecondValue = true;
                        TopRightWidthSecondValue = 8f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 10.01024f;
                        break;
                    case  Connections.LeftConnect:
                        setBottomTextureWidthSecondValue = true;
                        BottomTextureWidthSecondValue = 72;
                        setBottomWidthSecondValue = true;
                        BottomWidthSecondValue = -24f;
                        setBottomXSecondValue = true;
                        BottomXSecondValue = -4f;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 15;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 196;
                        setBottomLeftTextureWidthSecondValue = true;
                        BottomLeftTextureWidthSecondValue = 8;
                        setBottomLeftWidthSecondValue = true;
                        BottomLeftWidthSecondValue = 8f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.FlipHorizontal = false;
                        }
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 89;
                        setLeftTextureWidthSecondValue = true;
                        LeftTextureWidthSecondValue = 8;
                        setLeftWidthSecondValue = true;
                        LeftWidthSecondValue = 8f;
                        setMiddleWidthSecondValue = true;
                        MiddleWidthSecondValue = -16f;
                        setMiddleXSecondValue = true;
                        MiddleXSecondValue = -4f;
                        setTopWidthSecondValue = true;
                        TopWidthSecondValue = -24f;
                        setTopXSecondValue = true;
                        TopXSecondValue = -4f;
                        setTopLeftTextureHeightSecondValue = true;
                        TopLeftTextureHeightSecondValue = 16;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 15;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 100;
                        setTopLeftTextureWidthSecondValue = true;
                        TopLeftTextureWidthSecondValue = 8;
                        setTopLeftWidthSecondValue = true;
                        TopLeftWidthSecondValue = 8f;
                        break;
                }
                if (setBottomWidthFirstValue && setBottomWidthSecondValue)
                {
                    Bottom.Width = BottomWidthFirstValue * (1 - interpolationValue) + BottomWidthSecondValue * interpolationValue;
                }
                if (setBottomXFirstValue && setBottomXSecondValue)
                {
                    Bottom.X = BottomXFirstValue * (1 - interpolationValue) + BottomXSecondValue * interpolationValue;
                }
                if (setBottomRightTextureLeftFirstValue && setBottomRightTextureLeftSecondValue)
                {
                    BottomRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureLeftFirstValue* (1 - interpolationValue) + BottomRightTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomRightTextureTopFirstValue && setBottomRightTextureTopSecondValue)
                {
                    BottomRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureTopFirstValue* (1 - interpolationValue) + BottomRightTextureTopSecondValue * interpolationValue);
                }
                if (setBottomRightTextureWidthFirstValue && setBottomRightTextureWidthSecondValue)
                {
                    BottomRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureWidthFirstValue* (1 - interpolationValue) + BottomRightTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomRightWidthFirstValue && setBottomRightWidthSecondValue)
                {
                    BottomRight.Width = BottomRightWidthFirstValue * (1 - interpolationValue) + BottomRightWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMiddleWidthFirstValue && setMiddleWidthSecondValue)
                {
                    Middle.Width = MiddleWidthFirstValue * (1 - interpolationValue) + MiddleWidthSecondValue * interpolationValue;
                }
                if (setMiddleXFirstValue && setMiddleXSecondValue)
                {
                    Middle.X = MiddleXFirstValue * (1 - interpolationValue) + MiddleXSecondValue * interpolationValue;
                }
                if (setRightTextureWidthFirstValue && setRightTextureWidthSecondValue)
                {
                    Right.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureWidthFirstValue* (1 - interpolationValue) + RightTextureWidthSecondValue * interpolationValue);
                }
                if (setRightWidthFirstValue && setRightWidthSecondValue)
                {
                    Right.Width = RightWidthFirstValue * (1 - interpolationValue) + RightWidthSecondValue * interpolationValue;
                }
                if (setTopWidthFirstValue && setTopWidthSecondValue)
                {
                    Top.Width = TopWidthFirstValue * (1 - interpolationValue) + TopWidthSecondValue * interpolationValue;
                }
                if (setTopXFirstValue && setTopXSecondValue)
                {
                    Top.X = TopXFirstValue * (1 - interpolationValue) + TopXSecondValue * interpolationValue;
                }
                if (setTopRightHeightFirstValue && setTopRightHeightSecondValue)
                {
                    TopRight.Height = TopRightHeightFirstValue * (1 - interpolationValue) + TopRightHeightSecondValue * interpolationValue;
                }
                if (setTopRightTextureLeftFirstValue && setTopRightTextureLeftSecondValue)
                {
                    TopRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureLeftFirstValue* (1 - interpolationValue) + TopRightTextureLeftSecondValue * interpolationValue);
                }
                if (setTopRightTextureTopFirstValue && setTopRightTextureTopSecondValue)
                {
                    TopRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureTopFirstValue* (1 - interpolationValue) + TopRightTextureTopSecondValue * interpolationValue);
                }
                if (setTopRightTextureWidthFirstValue && setTopRightTextureWidthSecondValue)
                {
                    TopRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureWidthFirstValue* (1 - interpolationValue) + TopRightTextureWidthSecondValue * interpolationValue);
                }
                if (setTopRightWidthFirstValue && setTopRightWidthSecondValue)
                {
                    TopRight.Width = TopRightWidthFirstValue * (1 - interpolationValue) + TopRightWidthSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setBottomTextureWidthFirstValue && setBottomTextureWidthSecondValue)
                {
                    Bottom.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureWidthFirstValue* (1 - interpolationValue) + BottomTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureLeftFirstValue && setBottomLeftTextureLeftSecondValue)
                {
                    BottomLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureLeftFirstValue* (1 - interpolationValue) + BottomLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureTopFirstValue && setBottomLeftTextureTopSecondValue)
                {
                    BottomLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureTopFirstValue* (1 - interpolationValue) + BottomLeftTextureTopSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureWidthFirstValue && setBottomLeftTextureWidthSecondValue)
                {
                    BottomLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureWidthFirstValue* (1 - interpolationValue) + BottomLeftTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomLeftWidthFirstValue && setBottomLeftWidthSecondValue)
                {
                    BottomLeft.Width = BottomLeftWidthFirstValue * (1 - interpolationValue) + BottomLeftWidthSecondValue * interpolationValue;
                }
                if (setLeftTextureLeftFirstValue && setLeftTextureLeftSecondValue)
                {
                    Left.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureLeftFirstValue* (1 - interpolationValue) + LeftTextureLeftSecondValue * interpolationValue);
                }
                if (setLeftTextureWidthFirstValue && setLeftTextureWidthSecondValue)
                {
                    Left.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureWidthFirstValue* (1 - interpolationValue) + LeftTextureWidthSecondValue * interpolationValue);
                }
                if (setLeftWidthFirstValue && setLeftWidthSecondValue)
                {
                    Left.Width = LeftWidthFirstValue * (1 - interpolationValue) + LeftWidthSecondValue * interpolationValue;
                }
                if (setTopLeftTextureHeightFirstValue && setTopLeftTextureHeightSecondValue)
                {
                    TopLeft.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureHeightFirstValue* (1 - interpolationValue) + TopLeftTextureHeightSecondValue * interpolationValue);
                }
                if (setTopLeftTextureLeftFirstValue && setTopLeftTextureLeftSecondValue)
                {
                    TopLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureLeftFirstValue* (1 - interpolationValue) + TopLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setTopLeftTextureTopFirstValue && setTopLeftTextureTopSecondValue)
                {
                    TopLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureTopFirstValue* (1 - interpolationValue) + TopLeftTextureTopSecondValue * interpolationValue);
                }
                if (setTopLeftTextureWidthFirstValue && setTopLeftTextureWidthSecondValue)
                {
                    TopLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureWidthFirstValue* (1 - interpolationValue) + TopLeftTextureWidthSecondValue * interpolationValue);
                }
                if (setTopLeftWidthFirstValue && setTopLeftWidthSecondValue)
                {
                    TopLeft.Width = TopLeftWidthFirstValue * (1 - interpolationValue) + TopLeftWidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentConnectionsState = firstState;
                }
                else
                {
                    mCurrentConnectionsState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MessageBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MessageBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MessageBoxRuntime.Connections fromState,AbbatoirIntergrade.GumRuntimes.MessageBoxRuntime.Connections toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Connections toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Connections").States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentConnectionsState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Connections toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentConnectionsState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations ()
            {
                base.StopAnimations();
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height",
                            Type = "float",
                            Value = Middle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height Units",
                            Type = "DimensionUnitType",
                            Value = Middle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.SourceFile",
                            Type = "string",
                            Value = Middle.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Address",
                            Type = "TextureAddress",
                            Value = Middle.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Height",
                            Type = "int",
                            Value = Middle.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Left",
                            Type = "int",
                            Value = Middle.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Top",
                            Type = "int",
                            Value = Middle.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Width",
                            Type = "int",
                            Value = Middle.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width Units",
                            Type = "DimensionUnitType",
                            Value = Middle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Middle.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Units",
                            Type = "PositionUnitType",
                            Value = Middle.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y",
                            Type = "float",
                            Value = Middle.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Middle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Units",
                            Type = "PositionUnitType",
                            Value = Middle.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height",
                            Type = "float",
                            Value = TopLeft.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.SourceFile",
                            Type = "string",
                            Value = TopLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = TopLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Height",
                            Type = "int",
                            Value = TopLeft.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Width",
                            Type = "int",
                            Value = TopLeft.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width",
                            Type = "float",
                            Value = TopLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X",
                            Type = "float",
                            Value = TopLeft.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y",
                            Type = "float",
                            Value = TopLeft.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height",
                            Type = "float",
                            Value = Top.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height Units",
                            Type = "DimensionUnitType",
                            Value = Top.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.SourceFile",
                            Type = "string",
                            Value = Top.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Address",
                            Type = "TextureAddress",
                            Value = Top.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Height",
                            Type = "int",
                            Value = Top.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Width",
                            Type = "int",
                            Value = Top.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width Units",
                            Type = "DimensionUnitType",
                            Value = Top.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Top.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Units",
                            Type = "PositionUnitType",
                            Value = Top.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y",
                            Type = "float",
                            Value = Top.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Top.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Units",
                            Type = "PositionUnitType",
                            Value = Top.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height",
                            Type = "float",
                            Value = TopRight.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.SourceFile",
                            Type = "string",
                            Value = TopRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Address",
                            Type = "TextureAddress",
                            Value = TopRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Height",
                            Type = "int",
                            Value = TopRight.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Width",
                            Type = "int",
                            Value = TopRight.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width",
                            Type = "float",
                            Value = TopRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X",
                            Type = "float",
                            Value = TopRight.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Units",
                            Type = "PositionUnitType",
                            Value = TopRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y",
                            Type = "float",
                            Value = TopRight.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Units",
                            Type = "PositionUnitType",
                            Value = TopRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height",
                            Type = "float",
                            Value = Right.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height Units",
                            Type = "DimensionUnitType",
                            Value = Right.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.SourceFile",
                            Type = "string",
                            Value = Right.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Address",
                            Type = "TextureAddress",
                            Value = Right.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Height",
                            Type = "int",
                            Value = Right.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Width",
                            Type = "int",
                            Value = Right.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width",
                            Type = "float",
                            Value = Right.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width Units",
                            Type = "DimensionUnitType",
                            Value = Right.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X",
                            Type = "float",
                            Value = Right.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Right.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Units",
                            Type = "PositionUnitType",
                            Value = Right.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y",
                            Type = "float",
                            Value = Right.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Right.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Units",
                            Type = "PositionUnitType",
                            Value = Right.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height",
                            Type = "float",
                            Value = BottomRight.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.SourceFile",
                            Type = "string",
                            Value = BottomRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Height",
                            Type = "int",
                            Value = BottomRight.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Width",
                            Type = "int",
                            Value = BottomRight.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width",
                            Type = "float",
                            Value = BottomRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X",
                            Type = "float",
                            Value = BottomRight.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y",
                            Type = "float",
                            Value = BottomRight.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height",
                            Type = "float",
                            Value = Bottom.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.SourceFile",
                            Type = "string",
                            Value = Bottom.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Address",
                            Type = "TextureAddress",
                            Value = Bottom.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Height",
                            Type = "int",
                            Value = Bottom.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Width",
                            Type = "int",
                            Value = Bottom.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Bottom.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Units",
                            Type = "PositionUnitType",
                            Value = Bottom.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y",
                            Type = "float",
                            Value = Bottom.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Bottom.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Units",
                            Type = "PositionUnitType",
                            Value = Bottom.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height",
                            Type = "float",
                            Value = BottomLeft.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.SourceFile",
                            Type = "string",
                            Value = BottomLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Height",
                            Type = "int",
                            Value = BottomLeft.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Width",
                            Type = "int",
                            Value = BottomLeft.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width",
                            Type = "float",
                            Value = BottomLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X",
                            Type = "float",
                            Value = BottomLeft.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y",
                            Type = "float",
                            Value = BottomLeft.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height",
                            Type = "float",
                            Value = Left.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height Units",
                            Type = "DimensionUnitType",
                            Value = Left.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.SourceFile",
                            Type = "string",
                            Value = Left.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Address",
                            Type = "TextureAddress",
                            Value = Left.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Height",
                            Type = "int",
                            Value = Left.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Width",
                            Type = "int",
                            Value = Left.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width",
                            Type = "float",
                            Value = Left.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width Units",
                            Type = "DimensionUnitType",
                            Value = Left.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X",
                            Type = "float",
                            Value = Left.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Left.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Units",
                            Type = "PositionUnitType",
                            Value = Left.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y",
                            Type = "float",
                            Value = Left.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Left.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Units",
                            Type = "PositionUnitType",
                            Value = Left.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 43.05555f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 28.125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height",
                            Type = "float",
                            Value = Middle.Height + -160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height Units",
                            Type = "DimensionUnitType",
                            Value = Middle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.SourceFile",
                            Type = "string",
                            Value = Middle.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Address",
                            Type = "TextureAddress",
                            Value = Middle.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Height",
                            Type = "int",
                            Value = Middle.TextureHeight + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Left",
                            Type = "int",
                            Value = Middle.TextureLeft + 1990
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Top",
                            Type = "int",
                            Value = Middle.TextureTop + 1500
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Width",
                            Type = "int",
                            Value = Middle.TextureWidth + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width + -160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width Units",
                            Type = "DimensionUnitType",
                            Value = Middle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Middle.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Units",
                            Type = "PositionUnitType",
                            Value = Middle.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y",
                            Type = "float",
                            Value = Middle.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Middle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Units",
                            Type = "PositionUnitType",
                            Value = Middle.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height",
                            Type = "float",
                            Value = TopLeft.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.SourceFile",
                            Type = "string",
                            Value = TopLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = TopLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Height",
                            Type = "int",
                            Value = TopLeft.TextureHeight + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 1883
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 751
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Width",
                            Type = "int",
                            Value = TopLeft.TextureWidth + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width",
                            Type = "float",
                            Value = TopLeft.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X",
                            Type = "float",
                            Value = TopLeft.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y",
                            Type = "float",
                            Value = TopLeft.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height",
                            Type = "float",
                            Value = Top.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height Units",
                            Type = "DimensionUnitType",
                            Value = Top.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.SourceFile",
                            Type = "string",
                            Value = Top.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Address",
                            Type = "TextureAddress",
                            Value = Top.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Height",
                            Type = "int",
                            Value = Top.TextureHeight + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 1785
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 1256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Width",
                            Type = "int",
                            Value = Top.TextureWidth + 46
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width + -160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width Units",
                            Type = "DimensionUnitType",
                            Value = Top.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Top.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Units",
                            Type = "PositionUnitType",
                            Value = Top.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y",
                            Type = "float",
                            Value = Top.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Top.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Units",
                            Type = "PositionUnitType",
                            Value = Top.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height",
                            Type = "float",
                            Value = TopRight.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.SourceFile",
                            Type = "string",
                            Value = TopRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Address",
                            Type = "TextureAddress",
                            Value = TopRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Height",
                            Type = "int",
                            Value = TopRight.TextureHeight + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 1882
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 918
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Width",
                            Type = "int",
                            Value = TopRight.TextureWidth + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width",
                            Type = "float",
                            Value = TopRight.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X",
                            Type = "float",
                            Value = TopRight.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Units",
                            Type = "PositionUnitType",
                            Value = TopRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y",
                            Type = "float",
                            Value = TopRight.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Units",
                            Type = "PositionUnitType",
                            Value = TopRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height",
                            Type = "float",
                            Value = Right.Height + -160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height Units",
                            Type = "DimensionUnitType",
                            Value = Right.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.SourceFile",
                            Type = "string",
                            Value = Right.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Address",
                            Type = "TextureAddress",
                            Value = Right.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Height",
                            Type = "int",
                            Value = Right.TextureHeight + 117
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 1715
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 1423
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Width",
                            Type = "int",
                            Value = Right.TextureWidth + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width",
                            Type = "float",
                            Value = Right.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width Units",
                            Type = "DimensionUnitType",
                            Value = Right.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X",
                            Type = "float",
                            Value = Right.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Right.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Units",
                            Type = "PositionUnitType",
                            Value = Right.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y",
                            Type = "float",
                            Value = Right.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Right.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Units",
                            Type = "PositionUnitType",
                            Value = Right.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height",
                            Type = "float",
                            Value = BottomRight.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.SourceFile",
                            Type = "string",
                            Value = BottomRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Height",
                            Type = "int",
                            Value = BottomRight.TextureHeight + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 1882
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 1256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Width",
                            Type = "int",
                            Value = BottomRight.TextureWidth + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width",
                            Type = "float",
                            Value = BottomRight.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X",
                            Type = "float",
                            Value = BottomRight.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y",
                            Type = "float",
                            Value = BottomRight.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height",
                            Type = "float",
                            Value = Bottom.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.SourceFile",
                            Type = "string",
                            Value = Bottom.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Address",
                            Type = "TextureAddress",
                            Value = Bottom.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Height",
                            Type = "int",
                            Value = Bottom.TextureHeight + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 1833
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 1249
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Width",
                            Type = "int",
                            Value = Bottom.TextureWidth + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width + -160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Bottom.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Units",
                            Type = "PositionUnitType",
                            Value = Bottom.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y",
                            Type = "float",
                            Value = Bottom.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Bottom.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Units",
                            Type = "PositionUnitType",
                            Value = Bottom.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height",
                            Type = "float",
                            Value = BottomLeft.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.SourceFile",
                            Type = "string",
                            Value = BottomLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Height",
                            Type = "int",
                            Value = BottomLeft.TextureHeight + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 1883
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 1085
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Width",
                            Type = "int",
                            Value = BottomLeft.TextureWidth + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width",
                            Type = "float",
                            Value = BottomLeft.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X",
                            Type = "float",
                            Value = BottomLeft.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y",
                            Type = "float",
                            Value = BottomLeft.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height",
                            Type = "float",
                            Value = Left.Height + -160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height Units",
                            Type = "DimensionUnitType",
                            Value = Left.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.SourceFile",
                            Type = "string",
                            Value = Left.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Address",
                            Type = "TextureAddress",
                            Value = Left.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Height",
                            Type = "int",
                            Value = Left.TextureHeight + 117
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 1884
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 1426
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Width",
                            Type = "int",
                            Value = Left.TextureWidth + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width",
                            Type = "float",
                            Value = Left.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width Units",
                            Type = "DimensionUnitType",
                            Value = Left.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X",
                            Type = "float",
                            Value = Left.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Left.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Units",
                            Type = "PositionUnitType",
                            Value = Left.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y",
                            Type = "float",
                            Value = Left.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Left.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Units",
                            Type = "PositionUnitType",
                            Value = Left.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Connections state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Connections.RightConnect:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height",
                            Type = "float",
                            Value = TopRight.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Width",
                            Type = "int",
                            Value = TopRight.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width",
                            Type = "float",
                            Value = TopRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Width",
                            Type = "int",
                            Value = Right.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width",
                            Type = "float",
                            Value = Right.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Width",
                            Type = "int",
                            Value = BottomRight.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width",
                            Type = "float",
                            Value = BottomRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X
                        }
                        );
                        break;
                    case  Connections.LeftConnect:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Height",
                            Type = "int",
                            Value = TopLeft.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Width",
                            Type = "int",
                            Value = TopLeft.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width",
                            Type = "float",
                            Value = TopLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Width",
                            Type = "int",
                            Value = Bottom.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Width",
                            Type = "int",
                            Value = BottomLeft.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width",
                            Type = "float",
                            Value = BottomLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.FlipHorizontal",
                            Type = "bool",
                            Value = Left.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Width",
                            Type = "int",
                            Value = Left.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width",
                            Type = "float",
                            Value = Left.Width
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Connections state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Connections.RightConnect:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 10.68727f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 10.01024f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width + -16f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width + -24f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height",
                            Type = "float",
                            Value = TopRight.Height + 16f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 7
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Width",
                            Type = "int",
                            Value = TopRight.TextureWidth + 8
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width",
                            Type = "float",
                            Value = TopRight.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Width",
                            Type = "int",
                            Value = Right.TextureWidth + 8
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width",
                            Type = "float",
                            Value = Right.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 7
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 196
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Width",
                            Type = "int",
                            Value = BottomRight.TextureWidth + 8
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width",
                            Type = "float",
                            Value = BottomRight.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width + -24f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X + 4f
                        }
                        );
                        break;
                    case  Connections.LeftConnect:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width + -16f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Height",
                            Type = "int",
                            Value = TopLeft.TextureHeight + 16
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 15
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Width",
                            Type = "int",
                            Value = TopLeft.TextureWidth + 8
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width",
                            Type = "float",
                            Value = TopLeft.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width + -24f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Width",
                            Type = "int",
                            Value = Bottom.TextureWidth + 72
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width + -24f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 15
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 196
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Width",
                            Type = "int",
                            Value = BottomLeft.TextureWidth + 8
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width",
                            Type = "float",
                            Value = BottomLeft.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.FlipHorizontal",
                            Type = "bool",
                            Value = Left.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 89
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Width",
                            Type = "int",
                            Value = Left.TextureWidth + 8
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width",
                            Type = "float",
                            Value = Left.Width + 8f
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state)
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                    else if (category.Name == "Connections")
                    {
                        if(state.Name == "RightConnect") this.mCurrentConnectionsState = Connections.RightConnect;
                        if(state.Name == "LeftConnect") this.mCurrentConnectionsState = Connections.LeftConnect;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Middle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime TopLeft { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Top { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime TopRight { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Right { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BottomRight { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Bottom { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BottomLeft { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Left { get; set; }
            public Microsoft.Xna.Framework.Graphics.Texture2D MiddleSourceFile
            {
                get
                {
                    return Middle.SourceFile;
                }
                set
                {
                    if (Middle.SourceFile != value)
                    {
                        Middle.SourceFile = value;
                        MiddleSourceFileChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureHeight
            {
                get
                {
                    return Middle.TextureHeight;
                }
                set
                {
                    if (Middle.TextureHeight != value)
                    {
                        Middle.TextureHeight = value;
                        MiddleTextureHeightChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureLeft
            {
                get
                {
                    return Middle.TextureLeft;
                }
                set
                {
                    if (Middle.TextureLeft != value)
                    {
                        Middle.TextureLeft = value;
                        MiddleTextureLeftChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureTop
            {
                get
                {
                    return Middle.TextureTop;
                }
                set
                {
                    if (Middle.TextureTop != value)
                    {
                        Middle.TextureTop = value;
                        MiddleTextureTopChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureWidth
            {
                get
                {
                    return Middle.TextureWidth;
                }
                set
                {
                    if (Middle.TextureWidth != value)
                    {
                        Middle.TextureWidth = value;
                        MiddleTextureWidthChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler MiddleSourceFileChanged;
            public event System.EventHandler MiddleTextureHeightChanged;
            public event System.EventHandler MiddleTextureLeftChanged;
            public event System.EventHandler MiddleTextureTopChanged;
            public event System.EventHandler MiddleTextureWidthChanged;
            public MessageBoxRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "MessageBox");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState ()
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers)
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences ()
            {
                Middle = this.GetGraphicalUiElementByName("Middle") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                TopLeft = this.GetGraphicalUiElementByName("TopLeft") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Top = this.GetGraphicalUiElementByName("Top") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                TopRight = this.GetGraphicalUiElementByName("TopRight") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Right = this.GetGraphicalUiElementByName("Right") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BottomRight = this.GetGraphicalUiElementByName("BottomRight") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Bottom = this.GetGraphicalUiElementByName("Bottom") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BottomLeft = this.GetGraphicalUiElementByName("BottomLeft") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Left = this.GetGraphicalUiElementByName("Left") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer)
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize ()
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
        }
    }