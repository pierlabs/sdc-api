# coding: utf-8

import sys
from setuptools import setup, find_packages

NAME = "br.com.conductor.sdc"
VERSION = "1.0.0"



# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = ["urllib3 >= 1.10", "six >= 1.9", "certifi", "python-dateutil"]

setup(
    name=NAME,
    version=VERSION,
    description="API SDC 2016",
    author_email="pierlabs@conductor.com.br",
    url="http://pierlabs.io",
    keywords=["Swagger", "API SDC 2016"],
    install_requires=REQUIRES,
    packages=find_packages(),
    include_package_data=True,
    long_description="""\
    API desenvolvida para a 15\u00C2\u00AA semanda da computa\u00C3\u00A7\u00C3\u00A3o da UFPB em 2016
    """
)


