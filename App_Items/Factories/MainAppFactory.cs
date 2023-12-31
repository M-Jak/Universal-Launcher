﻿namespace Universal_Launcher.App_Items {
    public class MainAppFactory : IAppFactory{
        public App CreateApp(string name, string path, string iconPath, System.Drawing.Icon icon, SubAppType type) {
            if( AppUtilities.CheckFilePath(path) ) {
                return new MainApp(name, path, iconPath, icon);
            }
            else {
                throw new AppDoesNotExistException("The requested app does not exist.");
            }
        }
    }
}
