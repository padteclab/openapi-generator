/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.0.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * Category.h
 *
 * 
 */

#ifndef Category_H_
#define Category_H_



#include <string>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  Category 
{
public:
    Category() = default;
    explicit Category(boost::property_tree::ptree const& pt);
    virtual ~Category() = default;

    Category(const Category& other) = default; // copy constructor
    Category(Category&& other) noexcept = default; // move constructor

    Category& operator=(const Category& other) = default; // copy assignment
    Category& operator=(Category&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// Category members

    /// <summary>
    /// 
    /// </summary>
    int64_t getId() const;
    void setId(int64_t value);

    /// <summary>
    /// 
    /// </summary>
    std::string getName() const;
    void setName(std::string value);

protected:
    int64_t m_Id = 0L;
    std::string m_Name = "default-name";
};

std::vector<Category> createCategoryVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<Category>(const Category& val) {
    return val.toPropertyTree();
}

template<>
inline Category fromPt<Category>(const boost::property_tree::ptree& pt) {
    Category ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* Category_H_ */
