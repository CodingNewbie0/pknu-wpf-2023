﻿using Caliburn.Micro;
using System.Windows;
using wp09_caliburnApp.ViewModels;

namespace wp09_caliburnApp
{
    // Caliburn으로 MVVM 실행할 때 주요설정 진행
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize(); // Caliburn MVVM을 초기화
        }

        // 시작한 후에 초기화 진행
        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e); // 부모클래스 실행은 주석처리
            await DisplayRootViewForAsync<MainViewModel>();
        }
    }
}
