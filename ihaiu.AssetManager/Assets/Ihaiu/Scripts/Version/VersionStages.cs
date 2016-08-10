﻿namespace Ihaiu.Assets
{
    public enum VersionStages
    {
        [HelpAttribute("此版本表示该软件仅仅是一个假页面链接，通常包括所有的功能和页面布局，但是    页面中的功能都没有做完整的实现，只是做为整体网站的一个基础架构。")]
        Base,


        [HelpAttribute("软件的初级版本，表示该软件在此阶段以实现软件功能为主，通常只在软件开发者    内部交流，一般而言，该版本软件的Bug较多，需要继续修改，是测试版本。")]
        Alpha,

        [HelpAttribute("该版本相对于Alpha 版已经有了很大的进步，消除了严重错误，但还需要经过多次    测试来进一步消除，此版本主要的修改对象是软件的UI。修改的的Bug 经测试人    员测试确认后可发布到外网上，此时可将软件版本标注为 beta版。")]
        Beta,

        [HelpAttribute("该版本已经相当成熟了，基本上不存在导致错误的Bug，与即将发行的正式版本相差   无几。")]
        RC,

        [HelpAttribute("该版本意味“最终版本”，在前面版本的一系列测试版之后，终归会有一个正式的      版本，是最终交付用户使用的一个版本。该版本有时也称标准版。")]
        Release,
    }
}