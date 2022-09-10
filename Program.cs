using Arrays;

Tests.Input_data_must_be_initialized(null, null);
Tests.Input_data_must_be_initialized(new int[1], null);
Tests.Input_data_must_be_initialized(null, new int[1]);
Tests.Input_data_must_be_initialized(new int[1], new int[1]);

Tests.Length_of_arrays_must_be_same(new int[1], new int[2]);
Tests.Length_of_arrays_must_be_same(new int[2], new int[2]);