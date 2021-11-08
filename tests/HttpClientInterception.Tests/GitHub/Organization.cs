﻿// Copyright (c) Just Eat, 2017. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

namespace JustEat.HttpClientInterception.GitHub;

internal sealed class Organization
{
    public string Login { get; set; }

    public long Id { get; set; }

    public string Url { get; set; }
}
