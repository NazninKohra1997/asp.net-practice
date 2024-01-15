﻿using Autofac;
using Library.Web.Areas.Admin.Models;

namespace Library.Web
{
	public class WebModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<BookModel>().AsSelf();
		}
	}
}
