namespace MauiApp1
{
    using CommunityToolkit.Mvvm.ComponentModel;
    using TheGraphics = Microsoft.Maui.Graphics;

    /// <summary>
    ///     ビューモデル
    ///     
    ///     <list type="bullet">
    ///         <item>CommunityToolkit.Mvvm パッケージを NuGET でインストールしてほしい</item>
    ///     </list>
    /// </summary>
    public class MainPageViewModel : ObservableObject
    {
        /// <summary>
        ///     画像ファイルパス
        /// </summary>
        public string ImageFilePath { get; set; } = @"C:\Users\むずでょ\Documents\GitHub\MAUI-IDrawable-Practice\Workspace\adventure_field.png";

        /// <summary>
        ///     画像
        /// </summary>
        public TheGraphics.IImage Image { get; set; }
    }
}
