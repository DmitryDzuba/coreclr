cmake_minimum_required(VERSION 2.8.12.2)

set(CMAKE_INCLUDE_CURRENT_DIR ON)

set(SOURCES
  createdirectoryw.cpp
)

add_executable(paltest_createdirectoryw_test2
  ${SOURCES}
)

add_dependencies(paltest_createdirectoryw_test2 coreclrpal)

target_link_libraries(paltest_createdirectoryw_test2
  pthread
  m
  coreclrpal
)
