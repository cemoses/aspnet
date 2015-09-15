// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#pragma once

#include <string>

namespace dnx
{
    namespace servicing
    {
        std::wstring get_runtime_path(const std::wstring& servicing_root, bool is_default_servicing_location, dnx::trace_writer& trace_writer);
    }
}
