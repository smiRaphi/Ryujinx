namespace Ryujinx.Graphics.Gpu
{
#pragma warning disable CA2211 // Non-constant fields should not be visible
    /// <summary>
    /// General GPU and graphics configuration.
    /// </summary>
    public static class GraphicsConfig
    {
        /// <summary>
        /// Resolution scale.
        /// </summary>
        public static float ResScale = 1f;

        /// <summary>
        /// Max Anisotropy. Values range from 0 - 16. Set to -1 to let the game decide.
        /// </summary>
        public static float MaxAnisotropy = -1;

        /// <summary>
        /// Base directory used to write shader code dumps.
        /// Set to null to disable code dumping.
        /// </summary>
        public static string ShadersDumpPath;

        /// <summary>
        /// Fast GPU time calculates the internal GPU time ticks as if the GPU was capable of
        /// processing commands almost instantly, instead of using the host timer.
        /// This can avoid lower resolution on some games when GPU performance is poor.
        /// </summary>
        public static bool FastGpuTime = true;

        /// <summary>
        /// Enables or disables fast 2d engine texture copies entirely on CPU when possible.
        /// Reduces stuttering and # of textures in games that copy textures around for streaming,
        /// as textures will not need to be created for the copy, and the data does not need to be
        /// flushed from GPU.
        /// </summary>
        public static bool Fast2DCopy = true;

        /// <summary>
        /// Enables or disables the Just-in-Time compiler for GPU Macro code.
        /// </summary>
        public static bool EnableMacroJit = true;

        /// <summary>
        /// Enables or disables high-level emulation of common GPU Macro code.
        /// </summary>
        public static bool EnableMacroHLE = true;
        
        /// <summary>
        /// Title id of the current running game.
        /// Used by the shader cache and texture dumping.
        /// </summary>
        public static string TitleId;

        /// <summary>
        /// Enables or disables the shader cache.
        /// </summary>
        public static bool EnableShaderCache;

        /// <summary>
        /// Enables or disables shader SPIR-V compilation.
        /// </summary>
        public static bool EnableSpirvCompilationOnVulkan = true;

        /// <summary>
        /// Enables or disables recompression of compressed textures that are not natively supported by the host.
        /// </summary>
        public static bool EnableTextureRecompression = false;

        /// <summary>
        /// Enables or disables color space passthrough, if available.
        /// </summary>
        public static bool EnableColorSpacePassthrough = false;
        /// <summary>
        /// Base directory used to write the game textures, if texture dump is enabled.
        /// </summary>
        public static string TextureDumpPath;
        /// <summary>
        /// Indicates if textures should be saved using the PNG file format. If disabled, textures are saved as DDS.
        /// </summary>
        public static bool TextureDumpFormatPng;
        /// <summary>
        /// Enables dumping textures to file.
        /// </summary>
        public static bool EnableTextureDump;
        /// <summary>
        /// Monitors dumped texture files for change and applies them in real-time if enabled.
        /// </summary>
        public static bool EnableTextureRealTimeEdit;
    }
#pragma warning restore CA2211
}
